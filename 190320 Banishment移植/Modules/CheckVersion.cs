using Banishment.BaseLib;
using BanishmentVerifyDll;
using FSLib.App.SimpleUpdater;
using FSLib.App.SimpleUpdater.Defination;
using System;
using System.Windows.Forms;

namespace Banishment.Modules {
    class CheckVersion {
        public static void Start() {
            Log.D("检查更新。");
            string remoteVersion = Bsphp.GetVersion();
            if (CompareVersion(Const.version, remoteVersion) >= 0) {
                Log.D("当前版本已是最新。");
            } else {
                //Log.I(string.Format("发现新版本 {0} 。更新公告见公告栏。", remoteVersion));
                AutoUpdate();
            }
            ////test
            //string v1 = "v2.0.0", v2 = "v2.0.1";
            //Log.D(string.Format("TestVersionCmp: {0}, {1}, {2}", v1, v2, CompareVersion(v1, v2) >= 0));
            //v1 = "v2.0.0"; v2 = "v2.0.0.0";
            //Log.D(string.Format("TestVersionCmp: {0}, {1}, {2}", v1, v2, CompareVersion(v1, v2) >= 0));
            //v1 = "v2.0.0"; v2 = "v2.1";
            //Log.D(string.Format("TestVersionCmp: {0}, {1}, {2}", v1, v2, CompareVersion(v1, v2) >= 0));
            //v1 = "v2.0.0"; v2 = "v2.0.0.1";
            //Log.D(string.Format("TestVersionCmp: {0}, {1}, {2}", v1, v2, CompareVersion(v1, v2) >= 0));
        }
        /// <summary>
        /// 比对v1与v2大小，若相等返回0，否则取v1-v2的正负号乘以1
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>v1>v2 ? 1 : v1==v2 ? 0 : -1</returns>
        private static int CompareVersion(string v1, string v2) {
            string[] vv1 = v1.Replace("v", "").Split(' ')[0].Split('.');
            string[] vv2 = v2.Replace("v", "").Split(' ')[0].Split('.');
            
            try {
                for(int i=0; i<Math.Min(vv1.Length, vv2.Length); i++) {
                    if(int.Parse(vv1[i]) > int.Parse(vv2[i])) {
                        return 1;
                    }else if (int.Parse(vv1[i]) < int.Parse(vv2[i])) {
                        return -1;
                    }
                }
                if(vv1.Length > vv2.Length) {
                    for(int i=vv2.Length; i<vv1.Length; i++) {
                        if(int.Parse(vv1[i]) != 0) {
                            return 1;
                        }
                    }
                }else if(vv1.Length < vv2.Length) {
                    for (int i = vv1.Length; i < vv2.Length; i++) {
                        if (int.Parse(vv2[i]) != 0) {
                            return -1;
                        }
                    }
                }
                return 0;
            }catch (Exception e) {
                Log.E(string.Format("CheckVersion.CompareVersion.Exception: {0}", e.Message));
                return 0;
            }
        }

        private static void AutoUpdate() {
            var updater = Updater.CreateUpdaterInstance(
                new UpdateServerInfo[]{ 
                    new UpdateServerInfo("http://rayiooo.coding.me/Csharp_BanishmentRelease/{0}", "update_c.xml"),
                    new UpdateServerInfo("http://api.update.rayiooo.top/Banishment/update/{0}", "update_c.xml"),
                    new UpdateServerInfo("http://api.rayiooo.top/banishment/update/{0}", "update_c.xml")
	        });

            //var updater = Updater.CreateUpdaterInstance(Const.urlUpdateXml, "update_c.xml");
            updater.Error += (s, e) => {
                Log.E("更新发生了错误：" + updater.Context.Exception.Message);
            };
            updater.UpdatesFound += (s, e) => {
                Log.D("发现了新版本：" + updater.Context.UpdateInfo.AppVersion);
            };
            updater.NoUpdatesFound += (s, e) => {
                Log.D("没有新版本！");
            };
            updater.MinmumVersionRequired += (s, e) => {
                MessageBox.Show("当前版本过低无法使用自动更新！请在公告栏中手动下载新版本。");
            };
            Updater.CheckUpdateSimple();
        }
    }
}
