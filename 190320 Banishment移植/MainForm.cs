using System;
using System.Threading;
using System.Windows.Forms;
using _190320_Banishment移植.BaseLib;
using _190320_Banishment移植.WebOptions;
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
            InitializeMainGrid();
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
            Log.I("ChromiumWebBrowser loaded.");
            MainWeb.FrameLoadEnd += async (sender, e) => {
                if (e.Frame.IsMain) {
                    WebLib.ScrollTo(360, 950);
                }
            };
        }
        private void InitializeMainController() {
            Log.I("Banishment Version 3.0 Alpha.");
        }
        private void InitializeMainGrid() {
            MainGrid.Rows.Add("每日签到", "");
            MainGrid.Rows.Add("文章阅读数", "");
            MainGrid.Rows.Add("视频观看数", "");
            MainGrid.Rows.Add("文章阅读时长", "");
            MainGrid.Rows.Add("视频观看时长", "");
            MainGrid.Rows.Add("今日积分", "");
            MainGrid.Rows.Add("总积分", "");
        }

        private void MainBtnRun_Click(object sender, EventArgs e) {
            Thread thread = new Thread(WebGetScore.Start);
            thread.Start();
        }
    }
}
