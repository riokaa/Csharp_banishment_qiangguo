using _190320_Banishment移植.BaseLib;
using CefSharp;
using CefSharp.WinForms;
using HtmlAgilityPack;
using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace _190320_Banishment移植.WebOptions {
    class WebGetScore {
        public static void Start() {
            Log.I("Web getting score.");
            var MainWeb = MainForm.self.MainWeb;
            MainWeb.Load(Const.urlQGMyPoints);
            MainWeb.FrameLoadEnd += EndingEventAsync;
        }
        private static async void EndingEventAsync(object sender, FrameLoadEndEventArgs e) {
            if (e.Frame.IsMain) {
                var MainWeb = MainForm.self.MainWeb;
                MainWeb.FrameLoadEnd -= EndingEventAsync; //only trigger once
                Log.D("Web getting score: page loaded.");
                Thread.Sleep(1000);
                //: get html
                string html = await MainWeb.GetBrowser().MainFrame.GetSourceAsync();
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);
                //: analyze daily scores in html
                HtmlNodeCollection scoreNodes = htmlDoc.DocumentNode.SelectNodes(@"//div[@class='my-points-card-text']");
                if (scoreNodes != null && scoreNodes.Count > 0) {
                    int sum = 0;
                    for (int i = 0; i < scoreNodes.Count; i++) {
                        //: flush scores
                        HtmlNode node = scoreNodes[i];
                        MainForm.self.MainGrid.Rows[i].Cells[1].Value = node.InnerText;
                        Match match = Regex.Match(node.InnerText, @"([0-9]+)分/([0-9]+)分");
                        if (match.Groups.Count > 0) {
                            Const.score[i] = int.Parse(match.Groups[1].Value);
                        }
                        sum += Const.score[i];
                    }
                    //: flush progress bar
                    var progressBar = MainForm.self.MainProgressBar;
                    if (progressBar.InvokeRequired) {
                        progressBar.Invoke(new Action(() => {
                            progressBar.Value = 100 * sum / 31;
                        }));
                    } else {
                        progressBar.Value = 100 * sum / 31;
                    }
                }
                //: analyze total score
                HtmlNode totalNode = htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='my-points-block']");
                if (totalNode != null) {
                    Match match;
                    match = Regex.Match(totalNode.InnerText, @"今日累积积分([0-9]+)");
                    if (match.Groups.Count > 0) {
                        MainForm.self.MainGrid.Rows[5].Cells[1].Value = string.Format("{0}分", match.Groups[1]);
                    }
                    match = Regex.Match(totalNode.InnerText, @"可用积分([0-9]+)");
                    if (match.Groups.Count > 0) {
                        MainForm.self.MainGrid.Rows[6].Cells[1].Value = string.Format("{0}分", match.Groups[1]);
                    }
                }
            }
        }
    }
}
