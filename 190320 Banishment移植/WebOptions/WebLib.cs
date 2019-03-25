using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;

namespace _190320_Banishment移植.WebOptions {
    class WebLib {
        /// <summary>
        /// 光滑的网页滚动操作
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mode">0:绝对滚动;1:相对滚动</param>
        public static void ScrollTo(int x, int y, int mode = 0) {
            StringBuilder js = new StringBuilder();
            var browser = MainForm.self.MainWeb;
            if (mode == 0)
                js.AppendFormat("window.scrollTo({{left:{0},top:{1},behavior:\"smooth\"}});", x, y);
            else
                js.AppendFormat("window.scrollTo({{left:document.documentElement.scrollLeft+{0},top:document.documentElement.scrollTop+{1},behavior:\"smooth\"}});", x, y);
            if (browser.InvokeRequired) {
                browser.Invoke(new Action(() => {
                    browser.GetBrowser().MainFrame.EvaluateScriptAsync(js.ToString());
                }));
            } else {
                browser.GetBrowser().MainFrame.EvaluateScriptAsync(js.ToString());
            }
        }
    }

    /// <summary>
    /// 在自己窗口打开链接(_blank时不弹出新窗口)
    /// ChromiumWebBrowser初始化时执行 browser.LifeSpanHandler = new OpenPageSelf(); 即可
    /// </summary>
    internal class OpenPageSelf : ILifeSpanHandler {
        public bool DoClose(IWebBrowser browserControl, IBrowser browser) {
            return false;
        }
        public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser) { }
        public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser) { }
        public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl,
string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures,
IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser) {
            newBrowser = null;
            var chromiumWebBrowser = (ChromiumWebBrowser)browserControl;
            chromiumWebBrowser.Load(targetUrl);
            return true; //Return true to cancel the popup creation copyright by codebye.com.
        }
    }
}
