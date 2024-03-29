﻿using Banishment.BaseLib;
using BanishmentBaseDll;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Banishment {
    static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //全局异常处理
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException); //处理UI线程异常
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException); //处理非UI线程异常
            //执行主窗体
            Application.Run(new MainForm());
        }

        /// <summary>
        /// ui线程异常处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e) {
            string errlog = "";
            if (e.Exception is Exception error) {
                errlog = string.Format("出现应用程序未处理的UI线程异常。\r\nApplication UnhandledException:{0}\r\n堆栈信息:{1}",
                    error.Message, error.StackTrace);
            } else {
                errlog = string.Format("Application UnhandledError:{0}", e);
            }
            Log.D(errlog);
            if (Const.debug)
                return; //debug模式不上传日志
            if (Log.UploadLogFile()) {
                MessageBox.Show("程序因异常退出，请及时重启软件！异常日志已自动上传。\r\n" + errlog, "Banishment - Error", MessageBoxButtons.OK);
            } else {
                MessageBox.Show("程序因异常退出，请及时重启软件！异常日志上传失败。\r\n" + errlog, "Banishment - Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 非ui线程异常处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            string errlog = "";
            if (e.ExceptionObject is FileNotFoundException e1) {
                if (e1.Message.Contains("CefSharp.Core.dll")) {
                    var dr = MessageBox.Show("文件CefSharp.Core.dll或其依赖文件缺失！可能是没有安装VC++2015(x86)运行时库。是否打开网页下载安装？", "缺失支持库", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes) {
                        //打开网页下载vc++2015
                        Base.OpenBrowser("https://www.microsoft.com/zh-CN/download/details.aspx?id=48145");
                        MessageBox.Show("请在打开的页面中：\r\n1. 点击“下载”\r\n2. 选中32位的“vc_redist.x86.exe”下载、安装\r\n3. 再运行本软件", "缺失支持库", MessageBoxButtons.OK);
                        Environment.Exit(0);
                    }
                } else {
                    MessageBox.Show("程序文件缺失！即将打开修复程序，请自行选择线路进行修复。\r\n缺失内容：" + e1.Message, "警告");
                    Process.Start("修复工具.exe");
                }
                errlog = string.Format("出现文件缺失异常。\r\n异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}",
                     e1.GetType().Name, e1.Message, e1.StackTrace);
            } else if (e.ExceptionObject is Exception error) {
                errlog = string.Format("出现应用程序未处理的非UI线程异常。\r\n异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}",
                     error.GetType().Name, error.Message, error.StackTrace);
            } else {
                errlog = string.Format("应用程序线程错误:{0}", e);
            }
            Log.D(errlog);
            if (Const.debug)
                return;
            if (Log.UploadLogFile()) {
                MessageBox.Show("程序因异常退出，请及时重启软件！异常日志已自动上传。\r\n" + errlog, "Banishment - Error", MessageBoxButtons.OK);
            } else {
                MessageBox.Show("程序因异常退出，请及时重启软件！异常日志上传失败。\r\n" + errlog, "Banishment - Error", MessageBoxButtons.OK);
            }
        }
    }
}
