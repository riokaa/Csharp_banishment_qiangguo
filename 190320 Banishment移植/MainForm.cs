using _190320_Banishment移植.BaseLib;
using _190320_Banishment移植.WebOptions;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Threading;
using System.Windows.Forms;

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
            MainWeb = new ChromiumWebBrowser("https://pc.xuexi.cn/points/login.html?ref=https://www.xuexi.cn/") {
                Dock = DockStyle.Fill,
                LifeSpanHandler = new OpenPageSelf()
            };
            MainWeb.FrameLoadEnd += InitializeMainBrowserEndingEvent;
            MainSplitContainer1.Panel1.Controls.Add(MainWeb);
            Log.I("ChromiumWebBrowser loaded.");
        }
        private void InitializeMainBrowserEndingEvent(object sender, FrameLoadEndEventArgs e) {
            if (e.Frame.IsMain) {
                MainWeb.FrameLoadEnd -= InitializeMainBrowserEndingEvent; //only trigger once
                WebLib.ScrollTo(360, 950);
            }
        }
        private void InitializeMainController() {
            Log.I("Banishment Version 3.0 Alpha.");
        }
        private void InitializeMainGrid() {
            MainGrid.Rows.Add("每日签到", "未加载");
            MainGrid.Rows.Add("文章阅读数", "未加载");
            MainGrid.Rows.Add("视频观看数", "未加载");
            MainGrid.Rows.Add("文章阅读时长", "未加载");
            MainGrid.Rows.Add("视频观看时长", "未加载");
            MainGrid.Rows.Add("今日总积分", "未加载");
            MainGrid.Rows.Add("可用积分", "未加载");
        }

        private void MainBtnRun_Click(object sender, EventArgs e) {
            Thread threadControlLogic = new Thread(() => {
                WebGetScore.Start();
            });
            threadControlLogic.Start();
        }
    }
}
