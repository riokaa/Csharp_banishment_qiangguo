using FSLib.App.SimpleUpdater;
using System;
using System.Windows.Forms;

namespace 修复工具 {
    public partial class MainForm : Form {
        static Updater updater;

        public MainForm() {
            InitializeComponent();
            InitializeUpdater();
        }
        private void InitializeUpdater() {
            updater = Updater.CreateUpdaterInstance("http://rayiooo.coding.me/Csharp_BanishmentRelease/{0}", "update_c.xml");
            updater.Error += (s, e) => {
                MessageBox.Show(string.Format("更新发生了错误：{0}！可尝试更换更新源。", updater.Context.Exception.Message), "更新失败");
            };
            updater.NoUpdatesFound += (s, e) => {
                MessageBox.Show("没有新版本。");
            };
        }
        // 开发版线路
        private void btnUpdate1_Click(object sender, EventArgs e) {
            update("http://rayiooo.coding.me/Csharp_BanishmentRelease/{0}");
        }
        // 稳定版线路1
        private void btnUpdate2_Click(object sender, EventArgs e) {
            update("http://api.update.rayiooo.top/Banishment/update/{0}");
        }
        // 稳定版线路2
        private void btnUpdate3_Click(object sender, EventArgs e) {
            update("http://api.rayiooo.top/banishment/update/{0}");
        }

        private void update(string url) {
            updater.Context.UpdateDownloadUrl = url;
            updater.BeginCheckUpdateInProcess();
        }
    }
}
