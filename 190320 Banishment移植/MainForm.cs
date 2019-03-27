using Banishment.BaseLib;
using Banishment.WebOptions;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace Banishment {
    public partial class MainForm : Form {
        public ChromiumWebBrowser MainWeb;
        public static MainForm self;
        public ThreadsController threadController;

        public MainForm() {
            self = this;
            InitializeComponent();
            InitializeMainController();
            InitializeMainGrid();
            InitializeMainBrowser();
            InitializeThreads();
            InitializeUI();
        }

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
            MainSplitContainer1.Panel1.Controls.Add(MainWeb);
            Log.I("ChromiumWebBrowser loaded.");
        }
        private void InitializeMainBrowserEndingEvent(object sender, FrameLoadEndEventArgs e) {
            if (e.Frame.IsMain) {
                MainWeb.FrameLoadEnd -= InitializeMainBrowserEndingEvent; //only trigger once
                WebLib.ScrollTo(355, 960);
            }
        }
        private void InitializeMainController() {
            Log.I(string.Format("Banishment Version {0}.", Const.version));
            Log.W("此版本为测试版，不检测更新，新版本请关注v2.0.2版本公告栏。");
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
        private void InitializeThreads() {
            threadController = new ThreadsController();
            if (Const.debug) {
                Log.I("当前是 Debug 模式。");
                Log.I("当前是 Debug 模式。");
                Log.I("当前是 Debug 模式。");
            }
        }
        private void InitializeUI() {
            this.Text = string.Format("Banishment C#  {0}", Const.version);
            this.MainSplitContainer.SplitterDistance = (int)(MainSplitContainer.Height * 0.75);
            this.MainSplitContainer1.SplitterDistance = (int)(MainSplitContainer1.Width * 0.75);
        }

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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Environment.Exit(0);

        private void MainForm_Load(object sender, EventArgs e) {

        }
    }
}
