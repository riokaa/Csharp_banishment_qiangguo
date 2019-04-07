using Banishment.BaseLib;
using Banishment.NetWork;
using FSLib.App.SimpleUpdater;
using System.Windows.Forms;

namespace Banishment.Modules {
    class CheckVersion {
        public static void Start() {
            Log.D("检查更新。");
            ////获取新旧小版本号
            //string remoteVersion = Bsphp.GetVersion();
            //string[] remote = remoteVersion.Replace("v", "").Split(' ')[0].Split('.');
            //string[] local = Const.version.Replace("v", "").Split(' ')[0].Split('.');
            //if(remote.Length < 3) {
            //    Log.W(string.Format("获取新版本号失败。 [@remoteVersion={0}]", remoteVersion));
            //    return;
            //}
            ////计算版本权值
            //int remoteCount = int.Parse(remote[0]) * 10000 + int.Parse(remote[1]) * 100 + int.Parse(remote[2]);
            //int localCount = int.Parse(local[0]) * 10000 + int.Parse(local[1]) * 100 + int.Parse(local[2]);
            //if (localCount >= remoteCount) {
            //    //无更新
            //    Log.D("当前版本已是最新。");
            //} else {
            //    //有更新
            //    Log.I(string.Format("发现新版本 {0} 。更新公告见公告栏。", remoteVersion));
            //}
            AutoUpdate();
        }
        private static void AutoUpdate() {
            var updater = Updater.CreateUpdaterInstance(Const.urlUpdateXml, "update_c.xml");
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
