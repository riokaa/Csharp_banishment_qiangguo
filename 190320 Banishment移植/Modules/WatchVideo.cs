using Banishment.BaseLib;
using Banishment.NetWork;
using Banishment.WebOptions;
using CefSharp;
using HtmlAgilityPack;
using System;
using System.Text;
using System.Threading;

namespace Banishment.Modules {
    /// <summary>
    /// 视频观看
    /// </summary>
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
                if (Const.debug)
                    watchTime = 3000;
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

            //: sleep
            MainForm.self.threadController.ThreadProScrollResume();
            Thread.Sleep(watchTime); //睡觉
            MainForm.self.threadController.ThreadProScrollSuspend();

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

            //: select video type
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("function getElementByXpath(path) {return document.evaluate(path, document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;}");
            sb.AppendLine("getElementByXpath(\"//label[@for='icw2w2r402000_第一频道']\").click();");
            BrowserEvaluateScript(sb.ToString());
            Thread.Sleep(1000);

            sb = new StringBuilder();
            sb.AppendLine("function getElementByXpath(path) {return document.evaluate(path, document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;}");
            switch (_random.Next(0, 3)) {
                case 0:
                    sb.AppendLine("getElementByXpath(\"//label[@for='2p2eqv4lwtk00_习近平活动视频集']\").click();");
                    break;
                case 1:
                    sb.AppendLine("getElementByXpath(\"//label[@for='2p2eqv4lwtk00_专题报道']\").click();");
                    break;
                case 2:
                    sb.AppendLine("getElementByXpath(\"//label[@for='2p2eqv4lwtk00_新闻联播']\").click();");
                    break;
            }
            BrowserEvaluateScript(sb.ToString());
            BrowserWaitLoad();

            //: select video randomly
            string html = BrowserGetHtml();
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes(@"//div[@class='screen']//div[@class='word-item'][string-length()>10]");
            Log.I(string.Format("WatchVideo: {0} videos found.", nodes.Count));
            if (nodes.Count == 0) {
                Log.E("出问题了：没有获取到视频们！");
                return;
            }

            //: choose an article randomly
            HtmlNode selected = nodes[_random.Next(0, nodes.Count)];

            //: click it by js
            sb = new StringBuilder();
            sb.AppendLine("function getElementsByClassName(node,classname) {if (node.getElementsByClassName) {return node.getElementsByClassName(classname);} else {return (function getElementsByClass(searchClass,node) {if ( node == null )node=document;var classElements=[],els = node.getElementsByTagName(\"*\"),elsLen=els.length,pattern=new RegExp(\"(^|\\s)\"+searchClass+\"(\\s|$)\"), i, j;for (i = 0, j = 0; i < elsLen; i++) {if ( pattern.test(els[i].className) ) {classElements[j] = els[i]; j++;}}return classElements;})(classname, node);}}");
            sb.AppendLine("function getElementTitleEqualsTo(title){var elements = getElementsByClassName(document, \"word-item\");for(var i=0; i<elements.length;i++){if(elements[i].innerText == title){return elements[i];}}return null;}");
            sb.AppendLine("getElementTitleEqualsTo(\"" + selected.InnerText + "\").click();");
            BrowserEvaluateScript(sb.ToString());
            Log.I(string.Format("Loading video randomly... [@title='{0}']", selected.InnerText));
            BrowserWaitLoad();
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
