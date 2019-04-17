using Banishment.BaseLib;
using Banishment.NetWork;
using BanishmentImageDll;
using FSLib.Network.Http;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banishment {
    public partial class RegForm : Form {
        public RegForm() {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI() {
            //导入图片资源
            this.Icon = Src.GetIcon("MainIcon");
            this.RegPicBox.BackgroundImage = Src.GetImage("Rikka");
            //刷新验证码
            RegVerifyPic_Click(null, new EventArgs());
        }

        /// <summary>
        /// 更换验证码
        /// </summary>
        private void ChangeVerifyPic() {
            var context = new HttpClient().Create<Image>(HttpMethod.Get, BS.reqUrlCoode + BS.sessl);
            context.Send();
            if (context.IsValid()) {
                RegVerifyPic.BackgroundImage = context.Result;
            } else {
                Log.D(string.Format("ChangeVerifyPic.WrongRespStatus: {0}", context.Response.Status));
                Log.D(string.Format("ChangeVerifyPic.Resp: {0}", context.ResponseContent));
            }
        }
        /// <summary>
        /// 点击注册事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegBtnReg_Click(object sender, EventArgs e) {
            RegLabelWarn.Text = "";
            string response = Bsphp.Register(RegUser.Text, RegPwda.Text, RegPwdb.Text, RegEmail.Text, RegVerify.Text);
            RegLabelWarn.Text = response;
            if(response != "注册成功") {
                RegVerifyPic_Click(null, new EventArgs());
            }
        }
        /// <summary>
        /// 刷新验证码事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegVerifyPic_Click(object sender, EventArgs e) {
            Bsphp.UpdateSeSSL();
            ChangeVerifyPic();
            ChangeVerifyPic();
        }
    }
}
