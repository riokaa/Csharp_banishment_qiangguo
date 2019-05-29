using Banishment.BaseLib;
using Banishment.WebOptions;
using CefSharp;
using System.Threading;
using System.Threading.Tasks;

namespace Banishment.Modules {
    /// <summary>
    /// 封装异步执行的浏览器载入、获取源码、执行js功能，使之可以同步调用
    /// </summary>
    class OptionOnBrowser {
        private bool _htmlIsGot;
        private static bool _jsIsRan;
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
        protected static string BrowserEvaluateScriptWithResponseStatic(string js) {
            bool ok = false;
            var browser = MainForm.self.MainWeb;
            string ret = string.Empty;
            var task = browser.GetBrowser().MainFrame.EvaluateScriptAsync(js);
            task.ContinueWith(t => {
                if (!t.IsFaulted) {
                    var resp = task.Result;
                    ret = resp.Success ? (resp.Result.ToString() ?? "null") : resp.Message;
                }
                ok = true;
            });
            while (!ok)
                Thread.Sleep(1000);
            return ret;
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
            if (Const.debug) {
                Log.D(string.Format("OptionOnBrowser.Browser: referer={0}", WebLib.GetReferer(false)));
            }
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
