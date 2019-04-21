using Banishment.BaseLib;
using System;
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
                MessageBox.Show("程序因异常退出，请及时重启软件！异常日志已自动上传。", "Banishment - Error", MessageBoxButtons.OK);
            } else {
                MessageBox.Show("程序因异常退出，请及时重启软件！异常日志上传失败。", "Banishment - Error", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// 非ui线程异常处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            string errlog = "";
            if (e.ExceptionObject is Exception error) {
                errlog = string.Format("出现应用程序未处理的非UI线程异常。\r\n异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}",
                     error.GetType().Name, error.Message, error.StackTrace);
            } else {
                errlog = string.Format("应用程序线程错误:{0}", e);
            }
            Log.D(errlog);
            if (Const.debug)
                return;
            if (Log.UploadLogFile()) {
                MessageBox.Show("程序因异常退出，请及时重启软件！异常日志已自动上传。", "Banishment - Error", MessageBoxButtons.OK);
            } else {
                MessageBox.Show("程序因异常退出，请及时重启软件！异常日志上传失败。", "Banishment - Error", MessageBoxButtons.OK);
            }
        }
    }
}
