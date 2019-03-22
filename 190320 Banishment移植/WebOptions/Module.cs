using _190320_Banishment移植.BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190320_Banishment移植.WebOption {
    class WebGetScore {

        public static void Start() {
            Log.I("Web getting score.");
            var MainWeb = MainForm.self.MainWeb;
            MainWeb.Load(Const.urlQGMyPoints);
            MainWeb.FrameLoadEnd += (sender, args) => {
                if (args.Frame.IsMain) {
                    Log.I("Web getting score: page loaded.");
                    MainWeb.GetBrowser().MainFrame.GetSourceAsync().ContinueWith(taskHtml => {
                        Log.I("Html: " + taskHtml);
                    });
                }
            };
        }
    }
}
