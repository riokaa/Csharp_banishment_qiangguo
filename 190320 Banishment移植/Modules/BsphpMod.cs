using Banishment.BaseLib;
using BanishmentVerifyDll;
using System;
using System.Drawing;
using System.Threading;

namespace Banishment.Modules {
    /// <summary>
    /// 刷新用户信息
    /// </summary>
    class FlushUserInfo {
        public static bool Start() {
            string loginStatus = Bsphp.GetLoginInfo();
            switch (loginStatus) {
                case "1":
                    BS.user = Bsphp.GetUserInfo("用户名称");
                    BS.vipDate = Bsphp.GetUserInfo("到期时间");
                    if (Bsphp.GetUserInfo("是否到期").Equals("1")) {
                        BS.vip = true;
                    } else {
                        BS.vip = false;
                    }
                    AfterLoginSucceed();
                    return true;
                default:
                    BS.status = -1;
                    BS.vip = false;
                    AfterLoginFailed();
                    return false;
            }
        }
        /// <summary>
        /// 登陆成功后处理
        /// </summary>
        public static void AfterLoginSucceed() {
            MainForm main = MainForm.self;
            if (main.InvokeRequired) {
                main.Invoke(new Action(() => {
                    AfterLoginSucceedOption();
                }));
            } else {
                AfterLoginSucceedOption();
            }
        }
        private static void AfterLoginSucceedOption() {
            MainForm main = MainForm.self;
            main.UserBtnLogin.Visible = false;
            main.UserBtnRegister.Visible = false;
            main.UserLinkLabelLogout.Visible = true;
            main.UserBtnActivate.Enabled = true;
            main.UserBtnChangePwd.Enabled = true;
            main.UserLabelUsername.Text = BS.user;
            main.UserLabelVipDate.Text = BS.vipDate;
            if (BS.vip) {
                main.UserLabelVipStatus.ForeColor = Color.Green;
                main.UserLabelVipStatus.Text = "邪王真眼健在√";
                main.AboutBtnFeedback.Enabled = true;
                main.SetCheckIcon360.Enabled = true;
                main.SetCheckNoVoice.Enabled = true;
                if (main.SetCheckIcon360.Checked) {
                    main.Icon = BanishmentImageDll.Src.GetIcon("MainIcon360");
                    main.NotifyIcon.Icon = BanishmentImageDll.Src.GetIcon("MainIcon360");
                }
            } else {
                main.UserLabelVipStatus.ForeColor = Color.Red;
                main.UserLabelVipStatus.Text = "已到期";
                main.AboutBtnFeedback.Enabled = false;
                main.SetCheckIcon360.Enabled = false;
                main.SetCheckNoVoice.Enabled = false;
            }
            Log.I(string.Format("你好，{0}。", BS.user));
        }
        /// <summary>
        /// 登陆失败后处理
        /// </summary>
        public static void AfterLoginFailed() {
            MainForm main = MainForm.self;
            if (main.InvokeRequired) {
                main.Invoke(new Action(() => {
                    AfterLoginFailedOption();
                }));
            } else {
                AfterLoginFailedOption();
            }
        }
        private static void AfterLoginFailedOption() {
            MainForm main = MainForm.self;
            main.UserLabelUsername.Text = "未登录";
            main.UserLabelVipStatus.Text = "";
            main.UserLabelVipDate.Text = "";
            main.UserBtnLogin.Visible = true;
            main.UserBtnRegister.Visible = true;
            main.UserLinkLabelLogout.Visible = false;
            main.UserBtnActivate.Enabled = false;
            main.UserBtnChangePwd.Enabled = false;
            main.AboutBtnFeedback.Enabled = false;
            main.SetCheckIcon360.Enabled = false;
            main.SetCheckNoVoice.Enabled = false;
        }
    }

    /// <summary>
    /// 心跳包控制线程
    /// </summary>
    class Heart {
        public static void Start() {
            while (true) {
                string status = Bsphp.Heart();
                switch (status) {
                    case "5031":
                        Log.D("Heart.Start: 心跳正常。");
                        break;
                    default:
                        if (Bsphp.StatusCode.ContainsKey(status)) {
                            Log.W(string.Format("Pro用户状态: {0}", Bsphp.StatusCode[status]));
                        } else {
                            Log.W("获取Pro用户状态失败。");
                        }
                        break;
                }
                FlushUserInfo.Start();
                Thread.Sleep(15 * 60 * 1000); //15分钟一次心跳包
            }
        }
    }
}
