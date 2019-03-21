using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace _190320_Banishment移植 {
    public partial class MainForm : Form {
        public static MainForm self;
        public ChromiumWebBrowser MainWeb;

        public MainForm() {
            MainForm.self = this;
            InitializeComponent();
            InitializeMainController();
            InitializeMainBrowser();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void InitializeMainBrowser() {
            var settings = new CefSettings {
                Locale = "zh-CN",
                AcceptLanguageList = "zh-CN",
                MultiThreadedMessageLoop = true
            };
            Cef.Initialize(settings);
            MainWeb = new ChromiumWebBrowser("https://pc.xuexi.cn/points/login.html?ref=https://www.xuexi.cn/");
            MainSplitContainer.Panel1.Controls.Add(MainWeb);
            MainWeb.Dock = DockStyle.Fill;
            Log.I("ChromiumWebBrowser is loaded.");
        }
        private void InitializeMainController() {
            MainController.Text = "Banishment Version 3.0 Alpha.";
        }
    }
}
