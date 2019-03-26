using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _190320_Banishment移植.Modules {
    /// <summary>
    /// 封装异步执行的浏览器载入、获取源码、执行js功能，使之可以同步调用
    /// </summary>
    class OptionOnBrowser {
        private bool _htmlIsGot;
        private bool _jsIsRan;
        private bool _pageIsLoaded;

        protected void BrowserEvaluateScript(string js) {
            _jsIsRan = false;
            var browser = MainForm.self.MainWeb;
            browser.GetBrowser().MainFrame.EvaluateScriptAsync(js).ContinueWith(obj=> {
                _jsIsRan = true;
            });
            while (!_jsIsRan)
                Thread.Sleep(1000);
            return;
        }
        protected string BrowserGetHtml() {
            string html = "";
            _htmlIsGot = false;
            var browser = MainForm.self.MainWeb;
            var htmlTask = browser.GetBrowser().MainFrame.GetSourceAsync();
            htmlTask.ContinueWith(obj => {
                html = htmlTask.Result;
                _htmlIsGot = true;
            });

            while (!_htmlIsGot)
                Thread.Sleep(1000);
            return html;
        }
        protected void BrowserWaitLoad() {
            Thread.Sleep(1000);
            var browser = MainForm.self.MainWeb;
            browser.FrameLoadEnd += LoadEndEventAsync;
            while (!_pageIsLoaded)
                Thread.Sleep(1000);
            return;
        }
        protected void BrowserLoad(string url) {
            var browser = MainForm.self.MainWeb;
            browser.Load(url);
            browser.FrameLoadEnd += LoadEndEventAsync;
            while (!_pageIsLoaded)
                Thread.Sleep(1000);
            return;
        }
        private void LoadEndEventAsync(object sender, FrameLoadEndEventArgs e) {
            if (e.Frame.IsMain) {
                var browser = MainForm.self.MainWeb;
                browser.FrameLoadEnd -= LoadEndEventAsync; //only trigger once
                _pageIsLoaded = true;
            }
        }
    }
}
