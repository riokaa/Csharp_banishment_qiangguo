using _190320_Banishment移植.BaseLib;
using _190320_Banishment移植.Modules;
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
        public Mutex mainThreadSuspendMutex = new Mutex(false, "mainThreadSuspendMutex");
        public Thread threadMain;
        public Thread threadProMouseMove;
        public Thread threadProScroll;

        public MainForm() {
            self = this;
            InitializeComponent();
            InitializeMainController();
            InitializeMainGrid();
            InitializeMainBrowser();
            InitializeThreads();
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
                WebLib.ScrollTo(355, 960);
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
        private void InitializeThreads() {
            threadProMouseMove = new Thread(WebAction.ProMouseMove);
            threadProScroll = new Thread(WebAction.ProScroll);
        }

        private void MainBtnRun_Click(object sender, EventArgs e) {
            MainBtnRun.Enabled = false; //灰化按钮
            if (MainBtnRun.Text.Equals("开始执行")) {
                MainBtnRun.Text = "停止执行"; //at the begin
                threadMain = new Thread(Logic.Start);
                threadMain.Start();
            } else if (MainBtnRun.Text.Equals("停止执行")) {
                mainThreadSuspendMutex.WaitOne();
                threadMain.Abort();
                mainThreadSuspendMutex.ReleaseMutex();
                MainBtnRun.Text = "开始执行"; //at the end
            }
            MainBtnRun.Enabled = true; //复活按钮
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Environment.Exit(0);

        private void MainForm_Load(object sender, EventArgs e) {

        }
    }
}
