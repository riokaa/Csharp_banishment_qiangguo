using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;

namespace _190320_Banishment移植.WebOptions {
    class WebLib {
        public static string GetHtmlByJs(string tag = "html") {
            StringBuilder js = new StringBuilder();
            js.AppendLine("function tempFunction(){");
            js.AppendLine("    return document.getElementsByTagName('" + tag + "')[0].innerHTML;");
            js.AppendLine("}");
            js.AppendLine("tempFunction();");
            //var result = MainForm.self.MainWeb.GetBrowser().MainFrame.EvaluateScriptAsync(js.ToString()).Result;
            //return result.ToString();
            return "";
        }
        public static void ScrollTo(int x, int y) {
            StringBuilder js = new StringBuilder();
            var browser = MainForm.self.MainWeb;
            js.AppendFormat("window.scrollTo({0}, {1});", x, y);
            if (browser.InvokeRequired) {
                browser.Invoke(new Action(() => {
                    browser.GetBrowser().MainFrame.EvaluateScriptAsync(js.ToString());
                }));
            } else {
                browser.GetBrowser().MainFrame.EvaluateScriptAsync(js.ToString());
            }
        }
    }
}
