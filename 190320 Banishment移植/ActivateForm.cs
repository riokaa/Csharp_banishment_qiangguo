using Banishment.Modules;
using BanishmentVerifyDll;
using BanishmentImageDll;
using System;
using System.Windows.Forms;

namespace Banishment {
    public partial class ActivateForm : Form {
        public ActivateForm() {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI() {
            this.Icon = Src.GetIcon("MainIcon");
        }

        private void ActivateBtn_Click(object sender, EventArgs e) {
            string ka = ActivateTextBox.Text.Trim();
            string response = Bsphp.VipChong(BS.user, BS.pwd, 1, ka, "");
            ActivateLabelWarn.Text = response;
            if(response.Contains("激活成功")){
                FlushUserInfo.Start();
            }
        }
    }
}
