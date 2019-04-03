using Banishment.BaseLib;
using Banishment.NetWork;
using System.Threading;

namespace Banishment.Modules {
    /// <summary>
    /// 刷新用户信息
    /// </summary>
    class FlushUserInfo {
        public static void Start() {
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
                    break;
                default:
                    BS.status = -1;
                    BS.vip = false;
                    AfterLoginFailed();
                    break;
            }
        }
        /// <summary>
        /// 登陆成功后处理
        /// </summary>
        public static void AfterLoginSucceed() {
            //todo
        }
        /// <summary>
        /// 登陆失败后处理
        /// </summary>
        public static void AfterLoginFailed() {
            //todo
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
