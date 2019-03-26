using _190320_Banishment移植.BaseLib;
using _190320_Banishment移植.NetWork;
using _190320_Banishment移植.WebOptions;
using CefSharp;
using HtmlAgilityPack;
using System;
using System.Text;
using System.Threading;

namespace _190320_Banishment移植.Modules {
    class WatchVideo : OptionOnBrowser {
        private string _mode; //刷时间模式和刷数量模式
        private Random _random;

        public WatchVideo(string mode = "flush time") {
            _mode = mode;
            _random = new Random();
            Log.D(string.Format("WatchVideo: @mode='{0}'", _mode));
        }

        public void Start() {
            //: selecting logic
            Log.I("Watching video.");
            if(Const.videoList.Count > 0) { //有分发视频
                GoLocal();
            } else { //离线模式
                GoCenter();
            }

            //: sleep until read complete
            int watchTime = 60000 * _random.Next(7, 10);
            if (_mode.Equals("flush time")) {
                if (BS.vip) {
                    watchTime = watchTime * _random.Next(60, 150) / 100;
                }
            } else if (_mode.Equals("flush amount")) {
                watchTime = 60000;
                if (BS.vip) {
                    watchTime = watchTime + _random.Next(-20, 10) * 1000;
                }
            } else {
                Log.E(string.Format("ReadArticle: wrong mode content! [@mode='{0}']", _mode));
            }
            Log.I("开始执行观看 - " + (watchTime / 60000.0) + " - 分钟（即使不播放视频也可以积分）。");
            Log.I("Banishment this world!");
            switch (MainForm.self.threadProScroll.ThreadState) {
                case ThreadState.Unstarted:
                    MainForm.self.threadProScroll.Start();
                    break;
                case ThreadState.Suspended:
#pragma warning disable CS0618 // 类型或成员已过时
                    MainForm.self.threadProScroll.Resume();
#pragma warning restore CS0618 // 类型或成员已过时
                    break;
            }
            Thread.Sleep(watchTime); //睡觉
            if (MainForm.self.threadProScroll.ThreadState == ThreadState.Running) {
#pragma warning disable CS0618 // 类型或成员已过时
                MainForm.self.threadProScroll.Suspend();
#pragma warning restore CS0618 // 类型或成员已过时
            }

            //: ending option
            Log.I("Video watching complete.");
            return;
        }

        /// <summary>
        /// 离线模式 - 中央视频
        /// </summary>
        private void GoCenter() {
            //: load page
            Log.I("Loading learn TV...");
            BrowserLoad(Const.urlQGLearnTV);
            Log.I("Learn TV loaded.");

            //TODO
        }
        /// <summary>
        /// 地方视频: 根据分发的地方视频数据,进入地方视频网页
        /// </summary>
        private void GoLocal() {
            //: get video item randomly
            Log.I(string.Format("WatchVideo: {0} videos found.", Const.videoList.Count));
            int selectedItemIndex = _random.Next(0, Const.videoList.Count);
            WebVideoObject item = Const.videoList[selectedItemIndex];
            Const.videoList.RemoveAt(selectedItemIndex);
            Log.I(string.Format("Loading video randomly... [@title='{0}']", item.title));

            //: load page
            BrowserLoad(item.url);

            return;
        }
    }
}
