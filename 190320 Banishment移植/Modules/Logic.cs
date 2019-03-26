﻿using _190320_Banishment移植.BaseLib;
using _190320_Banishment移植.NetWork;
using _190320_Banishment移植.WebOptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace _190320_Banishment移植.Modules {
    /// <summary>
    /// 控制逻辑
    /// </summary>
    class Logic {

        public static void Start() {
            Log.I("Main thread: begin.");
            Const.videoList = new List<WebVideoObject>();
            new Thread(WebGetVideoList.Start).Start(); //获取视频列表分发
            while (true) {
                if (BS.vip) {
                    MainForm.self.threadController.ThreadProMouseMoveResume();
                } else {
                    MainForm.self.threadController.ThreadProMouseMoveSuspend();
                }
                new GetScore().Start();
                if (Const.score[3] < Const.scoreMax[3]) { //文章学习时长（优先时长）
                    if (Const.debug)
                        new WatchVideo("flush time").Start();
                    new ReadArticle("flush time").Start();
                } else if(Const.score[4] < Const.scoreMax[4]) { //视频学习时长
                    new WatchVideo("flush time").Start();
                } else if(Const.score[1] < Const.scoreMax[1]) { //阅读文章
                    new ReadArticle("flush amount").Start();
                } else if(Const.score[2] < Const.scoreMax[2]) { //观看视频
                    new WatchVideo("flush amount").Start();
                } else {
                    break;
                }
                Thread.Sleep(1000);
            }
            Log.I("恭喜您！今日网页端任务已全部完成。");
            if (Const.settingsAutoClose) {
                Log.I("即将执行自动关闭程序操作。");
                Environment.Exit(0);
            }
            if (Const.settingsAutoShutdown) {
                Log.I("10秒后将执行自动关机操作。");
                Process.Start("shutdown.exe", "-r -f -t 10");
            }
            MainForm.self.MainBtnRun.Invoke(new Action(() => {
                MainForm.self.MainBtnRun.Text = "开始执行";
            }));
        }
    }
}
