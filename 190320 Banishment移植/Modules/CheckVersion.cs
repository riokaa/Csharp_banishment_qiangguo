using Banishment.BaseLib;
using Banishment.Properties;
using BanishmentVerifyDll;
using FSLib.App.SimpleUpdater;
using System;
using System.Windows.Forms;

namespace Banishment.Modules {
    class CheckVersion {
        public static void Start() {
            Log.D("检查更新。");
            if (Settings.Default.UpdateSource == 0 && CompareVersion(Const.version, Bsphp.GetVersion()) >= 0) {
                //稳定版&&已最新
                Log.D("当前版本已是最新。");
                return;
            }
            AutoUpdate();
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
                Log.E(string.Format("CheckVersion.CompareVersion.Exception: {0} [@v1={1}][@v2={2}]", e.Message, v1, v2));
                return 0;
            }
        }

        private static void AutoUpdate() {
            Updater updater;
            switch (Settings.Default.UpdateSource) {
                case 0: //稳定版
                    updater = Updater.CreateUpdaterInstance("http://api.update.rayiooo.top/Banishment/update/{0}", "update_c.xml");
                    break;
                case 1: //开发版
                    updater = Updater.CreateUpdaterInstance("http://rayiooo.coding.me/Csharp_BanishmentRelease/{0}", "update_c.xml");
                    break;
                case 2: //未启用的线路2
                    updater = Updater.CreateUpdaterInstance("http://api.rayiooo.top/banishment/update/{0}", "update_c.xml");
                    break;
                default:
                    updater = Updater.CreateUpdaterInstance("http://api.update.rayiooo.top/Banishment/update/{0}", "update_c.xml");
                    break;
            }
            
            updater.Error += (s, e) => {
                MessageBox.Show("更新失败！请尝试以管理员身份运行软件，或者将软件目录移动到C盘以外的盘下再运行！", "提示");
                Log.E("更新发生了错误：" + updater.Context.Exception.Message);
                //MessageBox.Show(string.Format("更新发生了错误：{0}！可尝试在设置中更换更新源。", updater.Context.Exception.Message), "更新失败");
            };
            updater.UpdatesFound += (s, e) => {
                Log.D("发现了新版本：" + updater.Context.UpdateInfo.AppVersion);
            };
            updater.NoUpdatesFound += (s, e) => {
                Log.D("没有新版本。");
            };
            updater.MinmumVersionRequired += (s, e) => {
                MessageBox.Show("当前版本过低无法使用自动更新！请在公告栏中手动下载新版本。", "更新信息");
            };
            updater.BeginCheckUpdateInProcess();
        }
    }
}
