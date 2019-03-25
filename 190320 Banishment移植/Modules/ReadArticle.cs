using _190320_Banishment移植.BaseLib;
using _190320_Banishment移植.NetWork;
using CefSharp;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _190320_Banishment移植.Modules {
    class ReadArticle {
        public static string mode = "flush time"; //刷时间模式和刷数量模式
        public static void Start() {
            Log.I("Reading article.");
            var browser = MainForm.self.MainWeb;
            browser.Load(Const.urlQGMain);
            browser.FrameLoadEnd += EndingEventAsync;
        }
        private static async void EndingEventAsync(object sender, FrameLoadEndEventArgs e) {
            if (e.Frame.IsMain) {
                var browser = MainForm.self.MainWeb;
                browser.FrameLoadEnd -= EndingEventAsync; //only trigger once
                Log.D("ReadArticle: page loaded.");
                Thread.Sleep(3000);

                //: get html and article titles
                string html = await browser.GetBrowser().MainFrame.GetSourceAsync();
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);
                HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes(@"//div[@class='screen']//div[@class='word-item'][string-length()>10]");
                Log.I(string.Format("ReadArticle: {0} articles found.", nodes.Count));
                //foreach (HtmlNode n in nodes) {
                //    Log.I(n.InnerText);
                //}

                //: choose an article randomly
                Random random = new Random();
                HtmlNode selected = nodes[random.Next(0, nodes.Count)];

                //: click it by js
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("function getElementsByClassName(node,classname) {if (node.getElementsByClassName) {return node.getElementsByClassName(classname);} else {return (function getElementsByClass(searchClass,node) {if ( node == null )node=document;var classElements=[],els = node.getElementsByTagName(\"*\"),elsLen=els.length,pattern=new RegExp(\"(^|\\s)\"+searchClass+\"(\\s|$)\"), i, j;for (i = 0, j = 0; i < elsLen; i++) {if ( pattern.test(els[i].className) ) {classElements[j] = els[i]; j++;}}return classElements;})(classname, node);}}");
                sb.AppendLine("function getElementTitleEqualsTo(title){var elements = getElementsByClassName(document, \"word-item\");for(var i=0; i<elements.length;i++){if(elements[i].innerText == title){return elements[i];}}return null;}");
                sb.AppendLine("getElementTitleEqualsTo(\"" + selected.InnerText + "\").click();");
                await browser.GetBrowser().MainFrame.EvaluateScriptAsync(sb.ToString());
                Log.I(string.Format("Loading article randomly. [@title='{0}']", selected.InnerText));
                Thread.Sleep(2000);

                //: sleep until read complete
                int readTime = 60000 * random.Next(4, 7);
                if(mode.Equals("flush time")) {
                    if (BS.vip) {
                        readTime = readTime * random.Next(60, 150) / 100;
                    }
                }else if(mode.Equals("flush amount")) {
                    readTime = 60000;
                    if (BS.vip) {
                        readTime = readTime + random.Next(-20, 10) * 1000;
                    }
                } else {
                    Log.E(string.Format("ReadArticle: wrong mode content! [@mode='{0}']", mode));
                }
                Log.I("开始执行阅读 - " + (readTime / 60000.0) + " - 分钟。");
                Log.I("Banishment this world!");
#pragma warning disable CS0618 // 类型或成员已过时
                switch (MainForm.self.threadProScroll.ThreadState) {
                    case ThreadState.Unstarted:
                        MainForm.self.threadProScroll.Start();
                        break;
                    case ThreadState.Suspended:
                        MainForm.self.threadProScroll.Resume();
                        break;
                }
                Thread.Sleep(readTime); //睡觉
                if (MainForm.self.threadProScroll.ThreadState == ThreadState.Running) {
                    MainForm.self.threadProScroll.Suspend();
                }
                
                //: ending option
                if (MainForm.self.threadMain.ThreadState == ThreadState.Suspended) {
                    MainForm.self.threadMain.Resume();
                }
#pragma warning restore CS0618 // 类型或成员已过时
            }
        }
    }
}
