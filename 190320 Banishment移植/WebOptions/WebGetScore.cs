using _190320_Banishment移植.BaseLib;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;

namespace _190320_Banishment移植.WebOptions {
    class WebGetScore {
        public static void Start() {
            Log.I("Web getting score.");
            var MainWeb = MainForm.self.MainWeb;
            MainWeb.Load(Const.urlQGMyPoints);
            MainWeb.FrameLoadEnd += async (sender, e) => {
                if (e.Frame.IsMain) {
                    Log.D("Web getting score: page loaded.");
                    Thread.Sleep(1000);
                    //: get html
                    var html = await MainWeb.GetBrowser().MainFrame.GetSourceAsync();
                    var htmlDoc = new HtmlDocument();
                    htmlDoc.LoadHtml(html);
                    //: analyze scores in html
                    HtmlNodeCollection scoreNodes = htmlDoc.DocumentNode.SelectNodes(@"//div[@class='my-points-card-text']");
                    if(scoreNodes != null && scoreNodes.Count > 0) {
                        int sum = 0;
                        for(int i = 0; i < scoreNodes.Count; i++) {
                            //: flush scores
                            HtmlNode node = scoreNodes[i];
                            MainForm.self.MainGrid.Rows[i].Cells[1].Value = node.InnerText;
                            Match match = Regex.Match(node.InnerText, @"([0-9]+)分/([0-9]+)分");
                            Const.score[i] = int.Parse(match.Groups[1].Value);
                            sum += Const.score[i];
                        }
                        //: flush progress bar
                        if (MainForm.self.MainProgressBar.InvokeRequired) {
                            MainForm.self.MainProgressBar.Invoke(new Action(() => {
                                MainForm.self.MainProgressBar.Value = 100 * sum / 31;
                            }));
                        } else {
                            MainForm.self.MainProgressBar.Value = 100 * sum / 31;
                        }
                    }
                }
            };
        }
    }
}
