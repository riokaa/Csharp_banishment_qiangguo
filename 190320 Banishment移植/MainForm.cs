﻿using Banishment.BaseLib;
using Banishment.Modules;
using Banishment.Properties;
using Banishment.WebOptions;
using BanishmentImageDll;
using BanishmentVerifyDll;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Banishment {
    public partial class MainForm : Form {
        WebBrowser browserAnnounce;
        public bool browserInitialized = false;
        public ChromiumWebBrowser MainWeb;
        public static MainForm self;
        public ThreadsController threadController;
        public LinkLabel UserLinkLabelLogout;
        
        public MainForm() {
            self = this;
            InitializeComponent();
            InitializeDll();
            InitializeThreads();
            InitializeMainController();
            InitializeMainGrid();
            InitializeMainBrowser();
            InitializeUI();
            InitializeAutoLogin();
        }

        /// <summary>
        /// 个人中心自动登陆初始化
        /// </summary>
        private void InitializeAutoLogin() {
            LoginForm lf = new LoginForm();
            try {
                lf.LoginAuto();
            } finally {
                if(!(lf.IsDisposed || lf.Disposing)) {
                    lf.Dispose();
                }
            }
        }
        /// <summary>
        /// 程序分模块dll加载
        /// </summary>
        private void InitializeDll() {

        }
        /// <summary>
        /// 浏览器初始化
        /// </summary>
        private void InitializeMainBrowser() {
            var settings = new CefSettings {
                AcceptLanguageList = "zh-CN",
                Locale = "zh-CN",
                MultiThreadedMessageLoop = true,
            };
            settings.CefCommandLineArgs.Add("disable-gpu", "1");
            settings.CefCommandLineArgs.Add("disable-extensions", "1");
            //settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            Cef.Initialize(settings);
            MainWeb = new ChromiumWebBrowser("https://pc.xuexi.cn/points/login.html?ref=https://www.xuexi.cn/") {
                Dock = DockStyle.Fill,
                LifeSpanHandler = new OpenPageSelf(),
            };
            MainWeb.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
            threadController.ThreadNoVoiceStart(); //开启静音线程
            MainWeb.FrameLoadEnd += InitializeMainBrowserEndingEvent;
            MainSplitter1.Panel1.Controls.Add(MainWeb);
            Log.I("ChromiumWebBrowser loaded.");
        }
        private void InitializeMainBrowserEndingEvent(object sender, FrameLoadEndEventArgs e) {
            if (e.Frame.IsMain) {
                MainWeb.FrameLoadEnd -= InitializeMainBrowserEndingEvent; //only trigger once
                WebLib.ScrollTo(365, 900);
                threadController.ThreadNoVoiceAbort(); //结束静音线程
            }
        }
        private void OnIsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e) {
            if (e.IsBrowserInitialized) {
                this.browserInitialized = true;
            }
        }
        /// <summary>
        /// 控制台输出初始化
        /// </summary>
        private void InitializeMainController() {
            if (Const.debug) {
                MessageBox.Show("当前是 Debug 模式。", "!");
                Log.I("当前是 Debug 模式。");
                Log.I("当前是 Debug 模式。");
                Log.I("当前是 Debug 模式。");
            }
            Log.I(string.Format("Banishment Version {0}.", Const.version));
            Log.I("");
            Log.I("使用方式：扫码登陆后开始执行。");
            Log.I("本软件『完全可以免费使用』。");
        }
        /// <summary>
        /// 积分表格初始化
        /// </summary>
        private void InitializeMainGrid() {
            MainGrid.Rows.Add("每日签到", "未加载");
            MainGrid.Rows.Add("文章阅读数", "未加载");
            MainGrid.Rows.Add("视频观看数", "未加载");
            MainGrid.Rows.Add("文章阅读时长", "未加载");
            MainGrid.Rows.Add("视频观看时长", "未加载");
            MainGrid.Rows.Add("今日总积分", "未加载");
            MainGrid.Rows.Add("可用积分", "未加载");
        }
        /// <summary>
        /// 线程控制器初始化
        /// </summary>
        private void InitializeThreads() {
            threadController = new ThreadsController();
            threadController.ThreadCheckUpdateStart();
        }
        /// <summary>
        /// UI初始化
        /// </summary>
        private void InitializeUI() {
            //title
            this.Text = string.Format("Banishment C#  {0}", Const.version);
            //splitter width or height
            this.MainSplitter.SplitterDistance = (int)(MainSplitter.Height * 0.75);
            this.MainSplitter1.SplitterDistance = (int)(MainSplitter1.Width * 0.75);
            this.UserSplitter.SplitterDistance = (int)(UserSplitter.Width * 0.33);
            this.UserSplitter1.SplitterDistance = (int)(UserSplitter1.Height * 0.55);
            this.UserSplitter2.SplitterDistance = (int)(UserSplitter2.Height * 0.5);
            //图片自资源dll中加载
            this.Icon = Src.GetIcon("MainIcon");
            this.MainPicBoxRikka.BackgroundImage = Src.GetImage("Rikka");
            this.NotifyIcon.Icon = Src.GetIcon("MainIcon");
            this.UserImgHead.BackgroundImage = Src.GetImage("MainIcon");
            //user btn
            UserLinkLabelLogout = new LinkLabel() {
                Dock = DockStyle.Fill,
                Text = "注销登陆",
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false,
            };
            UserTable2.Controls.Add(UserLinkLabelLogout, 1, 0);
            UserBtnLogin.Click += (o, e) => { new LoginForm().Show(this); };
            UserBtnRegister.Click += (o, e) => { new RegForm().Show(this); };
            UserLinkLabelLogout.Click += (o, e) => {
                if(Bsphp.Logout() == "1") {
                    BS.user = "";
                    BS.pwd = "";
                    Bsphp.UpdateSeSSL();
                    Settings.Default.User = "";
                    Settings.Default.Pwd = "";
                    Settings.Default.Save();
                    FlushUserInfo.Start();
                }
            };
            //settings init
            SetUpdateSource.SelectedIndex = Settings.Default.UpdateSource;
            if (Settings.Default.AutoClose) {
                Const.settingsAutoClose = true;
                SetCheckAutoClose.Checked = true;
            }
            if (Settings.Default.AutoShutdown) {
                Const.settingsAutoShutdown = true;
                SetCheckAutoShutdown.Checked = true;
            }
            if (Settings.Default.NoVoice) {
                Const.settingsNoVoice = true;
                SetCheckNoVoice.Checked = true;
            }
            if (Settings.Default.Icon360) {
                Const.settingsIcon360 = true;
                SetCheckIcon360.Checked = true;
            }
        }

        /// <summary>
        /// 开始执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 程序关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Environment.Exit(0);

        /// <summary>
        /// 公告页进入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabPageAnnounce_Enter(object sender, EventArgs e) {
            browserAnnounce = new WebBrowser();
            browserAnnounce.Navigate(Const.urlAnnounce);
            browserAnnounce.Dock = DockStyle.Fill;
            tabPageAnnounce.Controls.Add(browserAnnounce);
        }
        /// <summary>
        /// 公告页切出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabPageAnnounce_Leave(object sender, EventArgs e) {
            tabPageAnnounce.Controls.Clear();
            browserAnnounce.Dispose();
        }
        /// <summary>
        /// 用户页切入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabPageUser_Enter(object sender, EventArgs e) {
            UserPicProCloud.BackgroundImage = Src.GetImage("Cloud");
        }

        private void UserBtnActivate_Click(object sender, EventArgs e) {
            new ActivateForm().Show(this);
        }

        private void UserBtnChangePwd_Click(object sender, EventArgs e) {
            new ChangePwdForm().Show(this);
        }

        private void AboutBtnFeedback_Click(object sender, EventArgs e) {
            string urlFeedback = @"http://verify.rayiooo.top/index.php?m=applib&c=appweb&a=feedback&daihao=10000000&uid=" + BS.user + "&table=快捷反馈&leix=feedback";
            WebForm wf = new WebForm();
            wf.LoadPage("快捷反馈  联系方式请填邮箱~", urlFeedback);
            wf.Show(this);
        }

        private void UserBtnGetPro_Click(object sender, EventArgs e) {
            WebForm wf = new WebForm();
            wf.LoadPage("Pro获取页", Const.urlPay);
            wf.Show(this);
        }

        private void UserLinkLabelProDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string urlProDetail = @"http://verify.rayiooo.top/index.php?m=applib&c=appweb&a=new_info&id=85";
            WebForm wf = new WebForm();
            wf.LoadPage("Pro功能介绍", urlProDetail);
            wf.Show(this);
        }
        /// <summary>
        /// 应用设置事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetBtnApply_Click(object sender, EventArgs e) {
            //自动关程序
            if (SetCheckAutoClose.Checked) {
                if (!Const.settingsAutoClose) {
                    Const.settingsAutoClose = true;
                    Settings.Default.AutoClose = true;
                    Log.I("设置：积分刷满后自动关闭程序开启。");
                }
            } else {
                if (Const.settingsAutoClose) {
                    Const.settingsAutoClose = false;
                    Settings.Default.AutoClose = false;
                    Log.I("设置：积分刷满后自动关闭程序关闭。");
                }
            }
            //自动关机
            if (SetCheckAutoShutdown.Checked) {
                if (!Const.settingsAutoShutdown) {
                    Const.settingsAutoShutdown = true;
                    Settings.Default.AutoShutdown = true;
                    Log.I("设置：积分刷满后自动关机开启。");
                }
            } else {
                if (Const.settingsAutoShutdown) {
                    Const.settingsAutoShutdown = false;
                    Settings.Default.AutoShutdown = false;
                    Log.I("设置：积分刷满后自动关机关闭。");
                }
            }
            //更新源
            Settings.Default.UpdateSource = SetUpdateSource.SelectedIndex;
            //静音
            if (SetCheckNoVoice.Checked) {
                if (!Const.settingsNoVoice) {
                    Const.settingsNoVoice = true;
                    Settings.Default.NoVoice = true;
                    Log.I("设置：静音功能开启。");
                }
            } else {
                if (Const.settingsNoVoice) {
                    Const.settingsNoVoice = false;
                    Settings.Default.NoVoice = false;
                    Log.I("设置：静音功能关闭。");
                }
            }
            //360Icon
            if (SetCheckIcon360.Checked) {
                if (!Const.settingsIcon360) {
                    Const.settingsIcon360 = true;
                    Settings.Default.Icon360 = true;
                    if (BS.vip) {
                        Log.I("设置：360伪装图标功能开启。");
                        this.Icon = Src.GetIcon("MainIcon360");
                        this.NotifyIcon.Icon = Src.GetIcon("MainIcon360");
                    }
                }
            } else {
                if (Const.settingsIcon360) {
                    Const.settingsIcon360 = false;
                    Settings.Default.Icon360 = false;
                    Log.I("设置：360伪装图标功能关闭。");
                    this.Icon = Src.GetIcon("MainIcon");
                    this.NotifyIcon.Icon = Src.GetIcon("MainIcon");
                }
            }
            //保存配置
            Settings.Default.Save();
            //反馈动作
            MessageBox.Show("设置已更改。", "~");
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                this.Show();
                WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void MainForm_Deactivate(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                NotifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void NotifyShow_Click(object sender, EventArgs e) {
            NotifyIcon_MouseDoubleClick(null, null);
        }

        private void NotifyExit_Click(object sender, EventArgs e) {
            MainForm_FormClosed(null, null);
        }
    }
}
