using Banishment.BaseLib;
using Banishment.Modules;
using Banishment.NetWork;
using Banishment.Properties;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Banishment {
    public partial class LoginForm : Form {
        public TextBox LoginTextUser;
        public TextBox LoginTextPwd;

        public LoginForm() {
            InitializeComponent();
            InitializeUI();
        }
        /// <summary>
        /// 界面初始化
        /// </summary>
        private void InitializeUI() {
            LoginTextUser = new TextBox() {
                Dock = DockStyle.Fill,
            };
            LoginTextPwd = new TextBox() {
                Dock = DockStyle.Fill,
                UseSystemPasswordChar = true,
            };

            //LoginTable.Controls.Add(new Label() {
            //    Dock = DockStyle.Fill,
            //    Text = "用户名：",
            //    TextAlign = ContentAlignment.MiddleRight,
            //}, 0, 0);
            //LoginTable.Controls.Add(new Label() {
            //    Dock = DockStyle.Fill,
            //    Text = "密码：",
            //    TextAlign = ContentAlignment.MiddleRight,
            //}, 0, 1);
            LoginTable.Controls.Add(LoginTextUser, 1, 0);
            LoginTable.Controls.Add(LoginTextPwd, 1, 1);
        }

        /// <summary>
        /// 开局自动登陆
        /// </summary>
        public void LoginAuto() {
            if (Settings.Default.User == "" || Settings.Default.Pwd == "")
                return;
            this.LoginTextUser.Text = Settings.Default.User;
            this.LoginTextPwd.Text = Base.AesDecrypt(Settings.Default.Pwd, Const.aesKey);
            this.LoginBtnLogin_Click(null, new EventArgs());
            if (!(this.IsDisposed || this.Disposing)) {
                Log.W("个人中心自动登陆失败。");
                FlushUserInfo.AfterLoginFailed(); //登录失败后处理
                this.Dispose();
            }
        }
        /// <summary>
        /// 登录按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtnLogin_Click(object sender, EventArgs e) {
            string user = LoginTextUser.Text;
            string pwd = LoginTextPwd.Text;
            string response = Bsphp.Login(user, pwd);
            string[] respArray = response.Split('|');
            if (respArray.Count() >= 5) { //登陆成功
                if (respArray[0] == "01") {
                    BS.status = int.Parse(respArray[1]);
                    BS.user = user;
                    BS.vipDate = respArray[4];
                    if (respArray[1] == "1011") {
                        BS.vip = true;
                    }
                    FlushUserInfo.AfterLoginSucceed();
                } else {
                    if (Bsphp.StatusCode.ContainsKey(respArray[1])) {
                        this.LoginRespLabel.Text = Bsphp.StatusCode[respArray[1]];
                    } else {
                        this.LoginRespLabel.Text = string.Format("登陆失败！错误码：{0}", respArray[1]);
                    }
                    return;
                }
            } else if (response == "9908") { //已到期
                BS.status = int.Parse(respArray[1]);
                for (int i = 0; i < 10; i++) {
                    Bsphp.Login(user, pwd);
                    if (FlushUserInfo.Start()) {
                        break;
                    }
                    Thread.Sleep(1000);
                }
                if (MainForm.self.InvokeRequired) {
                    MainForm.self.Invoke(new Action(() => {
                        MainForm.self.MainTab.SelectTab(1);
                    }));
                } else {
                    MainForm.self.MainTab.SelectTab(1);
                }
            } else { //登陆失败
                this.LoginRespLabel.Text = response;
                return;
            }
            BS.pwd = pwd;
            //自动登陆信息存储
            Settings.Default.User = user;
            Settings.Default.Pwd = Base.AesEncrypt(pwd, Const.aesKey);
            Settings.Default.Save();
            this.Dispose();
        }
        /// <summary>
        /// 忘记密码按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForgetLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("联系相关邮箱~", "忘记密码");
        }
    }
}
