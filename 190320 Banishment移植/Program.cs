using Banishment.BaseLib;
using System;
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

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            string str = "";
            string strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
            if (e.ExceptionObject is Exception error) {
                str = string.Format(strDateInfo + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n",
                     error.GetType().Name, error.Message, error.StackTrace);
            } else {
                str = string.Format("应用程序线程错误:{0}", e);
            }
            Log.D(str);
            Log.UploadLogFile();
            MessageBox.Show("Banishment软件因异常退出，请及重启软件！异常日志已发送给作者。", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e) {
            string str = "";
            string strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
            if (e.Exception is Exception error) {
                str = string.Format(strDateInfo + "Application UnhandledException:{0};\n\r堆栈信息:{1}", error.Message, error.StackTrace);
            } else {
                str = string.Format("Application UnhandledError:{0}", e);
            }
            Log.D(str);
            Log.UploadLogFile();
            MessageBox.Show("Banishment软件因异常退出，请及重启软件！异常日志已发送给作者。", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
