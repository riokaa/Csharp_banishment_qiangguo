using Banishment.BaseLib;
using Banishment.Modules;
using Banishment.NetWork;
using Banishment.Properties;
using Banishment.WebOptions;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banishment {
    public partial class MainForm : Form {
        WebBrowser browserAnnounce;
        public ChromiumWebBrowser MainWeb;
        public static MainForm self;
        public ThreadsController threadController;
        public Button UserBtnLogin;
        public Button UserBtnRegister;
        public Label UserLabelUsername;
        public Label UserLabelVipStatus;
        public Label UserLabelVipDate;
        public LinkLabel UserLinkLabelLogout;

        public MainForm() {
            self = this;
            InitializeComponent();
            InitializeMainController();
            InitializeMainGrid();
            InitializeMainBrowser();
            InitializeThreads();
            InitializeUI();
            InitializeAutoLogin();
        }

        /// <summary>
        /// 个人中心自动登陆初始化
        /// </summary>
        private void InitializeAutoLogin() {
            LoginForm lf = new LoginForm();
            try {
                lf.LoginAuto();
            } finally {
                if(!(lf.IsDisposed || lf.Disposing)) {
                    lf.Dispose();
                }
            }
        }
        /// <summary>
        /// 浏览器初始化
        /// </summary>
        private void InitializeMainBrowser() {
            var settings = new CefSettings {
                Locale = "zh-CN",
                AcceptLanguageList = "zh-CN",
                MultiThreadedMessageLoop = true
            };
            settings.CefCommandLineArgs.Add("disable-gpu", "1");
            Cef.Initialize(settings);
            MainWeb = new ChromiumWebBrowser("https://pc.xuexi.cn/points/login.html?ref=https://www.xuexi.cn/") {
                Dock = DockStyle.Fill,
                LifeSpanHandler = new OpenPageSelf()
            };
            MainWeb.FrameLoadEnd += InitializeMainBrowserEndingEvent;
            MainSplitter1.Panel1.Controls.Add(MainWeb);
            Log.I("ChromiumWebBrowser loaded.");
        }
        private void InitializeMainBrowserEndingEvent(object sender, FrameLoadEndEventArgs e) {
            if (e.Frame.IsMain) {
                MainWeb.FrameLoadEnd -= InitializeMainBrowserEndingEvent; //only trigger once
                WebLib.ScrollTo(365, 900);
            }
        }
        /// <summary>
        /// 控制台输出初始化
        /// </summary>
        private void InitializeMainController() {
            if (Const.debug) {
                MessageBox.Show("当前是 Debug 模式。", "!");
                Log.I("当前是 Debug 模式。");
                Log.I("当前是 Debug 模式。");
                Log.I("当前是 Debug 模式。");
            }
            Log.I(string.Format("Banishment Version {0}.", Const.version));
            Log.W("此版本为测试版，不检测更新，新版本请关注v2.0.2版本公告栏。");
            Log.I("使用方式：扫码登陆后开始执行。");
            Log.I("本软件『完全可以免费使用』。");
        }
        /// <summary>
        /// 积分表格初始化
        /// </summary>
        private void InitializeMainGrid() {
            MainGrid.Rows.Add("每日签到", "未加载");
            MainGrid.Rows.Add("文章阅读数", "未加载");
            MainGrid.Rows.Add("视频观看数", "未加载");
            MainGrid.Rows.Add("文章阅读时长", "未加载");
            MainGrid.Rows.Add("视频观看时长", "未加载");
            MainGrid.Rows.Add("今日总积分", "未加载");
            MainGrid.Rows.Add("可用积分", "未加载");
        }
        /// <summary>
        /// 线程控制器初始化
        /// </summary>
        private void InitializeThreads() {
            threadController = new ThreadsController();
            threadController.ThreadCheckUpdateStart();
        }
        /// <summary>
        /// UI初始化
        /// </summary>
        private void InitializeUI() {
            //title
            this.Text = string.Format("Banishment C#  {0}", Const.version);
            //splitter width or height
            this.MainSplitter.SplitterDistance = (int)(MainSplitter.Height * 0.75);
            this.MainSplitter1.SplitterDistance = (int)(MainSplitter1.Width * 0.75);
            this.UserSplitter.SplitterDistance = (int)(UserSplitter.Width * 0.33);
            this.UserSplitter1.SplitterDistance = (int)(UserSplitter1.Height * 0.55);
            this.UserSplitter2.SplitterDistance = (int)(UserSplitter2.Height * 0.5);
            //user table
            UserLabelUsername = new Label() {
                Dock = DockStyle.Fill,
                Text = "未登录",
                TextAlign = ContentAlignment.MiddleCenter,
            };
            UserLabelVipStatus = new Label() {
                Dock = DockStyle.Fill,
                ForeColor = Color.Red,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            UserLabelVipDate = new Label() {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            UserTable.Controls.Add(new Label() {
                Dock = DockStyle.Fill,
                Text = "用户名：",
                TextAlign = ContentAlignment.MiddleCenter,
            }, 0, 0);
            UserTable.Controls.Add(new Label() {
                Dock = DockStyle.Fill,
                Text = "Pro状态：",
                TextAlign = ContentAlignment.MiddleCenter,
            }, 0, 1);
            UserTable.Controls.Add(new Label() {
                Dock = DockStyle.Fill,
                Text = "到期时间：",
                TextAlign = ContentAlignment.MiddleCenter,
            }, 0, 2);
            UserTable.Controls.Add(UserLabelUsername, 1, 0);
            UserTable.Controls.Add(UserLabelVipStatus, 1, 1);
            UserTable.Controls.Add(UserLabelVipDate, 1, 2);
            //user btn
            UserBtnLogin = new Button() {
                Dock = DockStyle.Fill,
                Text = "登陆",
            };
            UserBtnRegister = new Button() {
                Dock = DockStyle.Fill,
                Text = "注册",
            };
            UserLinkLabelLogout = new LinkLabel() {
                Dock = DockStyle.Fill,
                Text = "注销登陆",
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false,
            };
            UserTable.Controls.Add(UserBtnLogin, 0, 3);
            UserTable.Controls.Add(UserBtnRegister, 1, 3);
            UserTable.Controls.Add(UserLinkLabelLogout, 1, 3);
            UserBtnLogin.Click += (o, e) => { new LoginForm().Show(this); };
            UserBtnRegister.Click += (o, e) => { new RegForm().Show(this); };
            UserLinkLabelLogout.Click += (o, e) => {
                if(Bsphp.Logout() == "1") {
                    BS.user = "";
                    BS.pwd = "";
                    Bsphp.UpdateSeSSL();
                    Settings.Default.User = "";
                    Settings.Default.Pwd = "";
                    Settings.Default.Save();
                    FlushUserInfo.Start();
                }
            };
        }

        /// <summary>
        /// 开始执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainBtnRun_Click(object sender, EventArgs e) {
            MainBtnRun.Enabled = false; //灰化按钮
            if (MainBtnRun.Text.Equals("开始执行")) {
                MainBtnRun.Text = "停止执行"; //at the begin
                threadController.ThreadMainStart();
            } else if (MainBtnRun.Text.Equals("停止执行")) {
                threadController.ThreadMainAbort();
                threadController.ThreadProMouseMoveSuspend();
                threadController.ThreadProScrollSuspend();
                MainBtnRun.Text = "开始执行"; //at the end
            }
            MainBtnRun.Enabled = true; //复活按钮
        }

        /// <summary>
        /// 程序关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Environment.Exit(0);

        /// <summary>
        /// 公告页进入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabPageAnnounce_Enter(object sender, EventArgs e) {
            browserAnnounce = new WebBrowser();
            browserAnnounce.Navigate(Const.urlAnnounce);
            browserAnnounce.Dock = DockStyle.Fill;
            tabPageAnnounce.Controls.Add(browserAnnounce);
        }
        /// <summary>
        /// 公告页切出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabPageAnnounce_Leave(object sender, EventArgs e) {
            tabPageAnnounce.Controls.Clear();
            browserAnnounce.Dispose();
        }

        private void UserBtnGetPro_Click(object sender, EventArgs e) {
            WebForm wf = new WebForm();
            wf.LoadPage("Pro获取页", Const.urlPay);
            wf.Show(this);
        }

        private void UserBtnActivate_Click(object sender, EventArgs e) {
            new ActivateForm().Show(this);
        }

        private void UserBtnChangePwd_Click(object sender, EventArgs e) {
            new ChangePwdForm().Show(this);
        }
    }
}
