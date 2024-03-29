﻿using Banishment.BaseLib;
using HtmlAgilityPack;
using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Banishment.Modules {
    class GetScore : OptionOnBrowser {

        public GetScore() {

        }
        public void Start() {
            //: load page
            Log.I("Web getting score.");
            BrowserLoad(Const.urlQGMyPoints);
            Log.D("WebGetScore: page loaded.");
            Thread.Sleep(2000);

            //: get html
            string html = BrowserGetHtml();

            //: analyze daily scores in html
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            HtmlNodeCollection scoreNodes = htmlDoc.DocumentNode.SelectNodes(@"//div[@class='my-points-card-text']");
            if (scoreNodes != null && scoreNodes.Count > 0) {
                int sum = 0;
                for (int i = 0; i < scoreNodes.Count; i++) {
                    //: flush scores
                    HtmlNode node = scoreNodes[i];
                    MainForm.self.MainGrid.Rows[i].Cells[1].Value = node.InnerText;
                    Match match = Regex.Match(node.InnerText, @"([0-9]+)分/([0-9]+)分");
                    if (match.Groups.Count > 2) {
                        Const.score[i] = int.Parse(match.Groups[1].Value);
                        Const.scoreMax[i] = int.Parse(match.Groups[2].Value);
                        //Log.D(string.Format("获取到积分上限{0}：{1}分。", i, Const.scoreMax[i]));
                    }
                    sum += Const.score[i];
                }
                int sumMax = 0;
                foreach(int i in Const.scoreMax) {
                    sumMax += i;
                }
                //: flush progress bar
                var progressBar = MainForm.self.MainProgressBar;
                if (progressBar.InvokeRequired) {
                    progressBar.Invoke(new Action(() => {
                        progressBar.Value = 100 * sum / sumMax;
                    }));
                } else {
                    progressBar.Value = 100 * sum / sumMax;
                }
            }

            //: analyze total score
            HtmlNode totalNode = htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='my-points-block']");
            if (totalNode != null) {
                Match match;
                match = Regex.Match(totalNode.InnerText, @"今日累积积分([0-9]+)");
                if (match.Groups.Count > 0) {
                    MainForm.self.MainGrid.Rows[5].Cells[1].Value = string.Format("{0}分", match.Groups[1]);
                    Log.I(string.Format("今日累计积分：{0}分。", match.Groups[1]));
                }
                match = Regex.Match(totalNode.InnerText, @"可用积分([0-9]+)");
                if (match.Groups.Count > 0) {
                    MainForm.self.MainGrid.Rows[6].Cells[1].Value = string.Format("{0}分", match.Groups[1]);
                }
            }

            return;
        }
    }
}
