using Banishment.BaseLib;
using Banishment.NetWork;
using CefSharp;
using HtmlAgilityPack;
using System;
using System.Text;
using System.Threading;

namespace Banishment.Modules {
    class ReadArticle : OptionOnBrowser {
        private string _mode; //刷时间模式和刷数量模式
        private Random _random;

        public ReadArticle(string mode = "flush time") {
            _mode = mode;
            _random = new Random();
            Log.D(string.Format("ReadArticle: @mode='{0}'", _mode));
        }

        public void Start() {
            //: load page
            Log.I("Reading article.");
            Log.I("ReadArticle: page loading...");
            BrowserLoad(Const.urlQGMain);
            Log.D("ReadArticle: page loaded.");

            //: get html and article titles
            string html = BrowserGetHtml();
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes(@"//div[@class='screen']//div[@class='word-item'][string-length()>10]");
            Log.I(string.Format("ReadArticle: {0} articles found.", nodes.Count));
            if(nodes.Count == 0) {
                Log.E("出问题了：没有获取到文章们！");
                return;
            }
            //foreach (HtmlNode n in nodes) {
            //    Log.I(n.InnerText);
            //}

            //: choose an article randomly
            HtmlNode selected = nodes[_random.Next(0, nodes.Count)];

            //: click it by js
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("function getElementsByClassName(node,classname) {if (node.getElementsByClassName) {return node.getElementsByClassName(classname);} else {return (function getElementsByClass(searchClass,node) {if ( node == null )node=document;var classElements=[],els = node.getElementsByTagName(\"*\"),elsLen=els.length,pattern=new RegExp(\"(^|\\s)\"+searchClass+\"(\\s|$)\"), i, j;for (i = 0, j = 0; i < elsLen; i++) {if ( pattern.test(els[i].className) ) {classElements[j] = els[i]; j++;}}return classElements;})(classname, node);}}");
            sb.AppendLine("function getElementTitleEqualsTo(title){var elements = getElementsByClassName(document, \"word-item\");for(var i=0; i<elements.length;i++){if(elements[i].innerText == title){return elements[i];}}return null;}");
            sb.AppendLine("getElementTitleEqualsTo(\"" + selected.InnerText + "\").click();");
            BrowserEvaluateScript(sb.ToString());
            Log.I(string.Format("Loading article randomly... [@title='{0}']", selected.InnerText));
            BrowserWaitLoad();

            //: sleep until read complete
            int readTime = 60000 * _random.Next(4, 7);
            if (_mode.Equals("flush time")) {
                if (BS.vip) {
                    readTime = readTime * _random.Next(60, 150) / 100;
                }
                //if (Const.debug)
                //    readTime = 3000;
            } else if (_mode.Equals("flush amount")) {
                readTime = 60000;
                if (BS.vip) {
                    readTime = readTime + _random.Next(-20, 10) * 1000;
                }
            } else {
                Log.E(string.Format("ReadArticle: wrong mode content! [@mode='{0}']", _mode));
            }
            Log.I("开始执行阅读 - " + (readTime / 60000.0) + " - 分钟。");
            Log.I("Banishment this world!");

            //: sleep
            MainForm.self.threadController.ThreadProScrollResume();
            Thread.Sleep(readTime); //睡觉
            MainForm.self.threadController.ThreadProScrollSuspend();

            //: ending option
            Log.I("Article reading complete.");
            return;
        }
    }
}
