using System;
using System.Windows.Forms;
using _190320_Banishment移植.BaseLib;
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

        private void InitializeMainBrowser() {
            var settings = new CefSettings {
                Locale = "zh-CN",
                AcceptLanguageList = "zh-CN",
                MultiThreadedMessageLoop = true
            };
            Cef.Initialize(settings);
            MainWeb = new ChromiumWebBrowser("https://pc.xuexi.cn/points/login.html?ref=https://www.xuexi.cn/");
            MainSplitContainer1.Panel1.Controls.Add(MainWeb);
            MainWeb.Dock = DockStyle.Fill;
            Log.I("ChromiumWebBrowser is loaded.");
        }
        private void InitializeMainController() {
            MainController.Text = "Banishment Version 3.0 Alpha.";
        }

        private void MainBtnRun_Click(object sender, EventArgs e) {

        }
    }
}
