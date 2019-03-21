using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace _190320_Banishment移植 {
    public partial class MainForm : Form {
        public ChromiumWebBrowser MainWeb;
        public MainForm() {
            InitializeComponent();
            InitializeBrowser();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void InitializeBrowser() {
            var settings = new CefSettings {
                Locale = "zh-CN",
                AcceptLanguageList = "zh-CN",
                MultiThreadedMessageLoop = true
            };
            Cef.Initialize(settings);
            MainWeb = new ChromiumWebBrowser("https://pc.xuexi.cn/points/login.html");
            MainSplitContainer.Panel1.Controls.Add(MainWeb);
            MainWeb.Dock = DockStyle.Fill;
        }
    }
}
