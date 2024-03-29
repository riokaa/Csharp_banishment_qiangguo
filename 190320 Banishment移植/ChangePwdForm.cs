﻿using BanishmentBaseDll;
using BanishmentImageDll;
using BanishmentVerifyDll;
using Banishment.Properties;
using System;
using System.Windows.Forms;
using Banishment.BaseLib;

namespace Banishment {
    public partial class ChangePwdForm : Form {
        public ChangePwdForm() {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI() {
            this.Icon = Src.GetIcon("MainIcon");
        }

        private void BtnChange_Click(object sender, EventArgs e) {
            string response = Bsphp.ChangePassword(BS.user, Pwd.Text, Pwda.Text, Pwdb.Text);
            LabelWarn.Text = response;
            if (response.Contains("成功")) {
                BS.pwd = Pwda.Text;
                Settings.Default.Pwd = Base.AesEncrypt(BS.pwd, Const.aesKey);
                Settings.Default.Save();
            }
        }
    }
}
