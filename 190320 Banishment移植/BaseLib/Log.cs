using BanishmentBaseDll;
using BanishmentMailDll;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Banishment.BaseLib {
    public class Log {
        public static StringBuilder logstorage = new StringBuilder();
        public static StringBuilder output = new StringBuilder();

        public static void D(string log) {
            LogOut("debug", log);
        }
        public static void I(string log) {
            LogOut("info", log);
        }
        public static void W(string log) {
            LogOut("warn", log);
        }
        public static void E(string log) {
            LogOut("error", log);
        }
        public static void F(string log) {
            LogOut("fatal", log);
        }
        private static void LogOut(string style, string log) {
            string temp = string.Format("{0} [{1}] : {2}", Base.GetCurrentTime(), style, log);
            Console.WriteLine(temp);
            logstorage.AppendLine(temp);
            switch (style) {
                case "debug":
                    if (Const.debug) {
                        output.AppendLine(temp);
                        ControllerFlush();
                    }
                    break;
                case "fatal":
                    output.AppendLine(temp);
                    ControllerFlush();
                    MessageBox.Show(temp, "Fatal!");
                    break;
                default:
                    output.AppendLine(temp);
                    ControllerFlush();
                    break;
            }
        }
        public static void ControllerFlush() {
            //清理控制台
            string str = output.ToString();
            if(str.Length >= 100000) {
                output = new StringBuilder();
                output.AppendLine(string.Format("{0} [info] : {1}", Base.GetCurrentTime(), "控制台自动清理完毕。"));
            }
            //刷新控制台
            var controller = MainForm.self.MainController;
            if (controller.InvokeRequired) {
                controller.Invoke(new Action(() => {
                    controller.Text = str;
                    controller.Focus();//获取焦点
                    controller.Select(controller.TextLength, 0);//光标定位到文本最后
                    controller.ScrollToCaret();//滚动到光标处
                }));
            } else {
                controller.Text = str;
                controller.Focus();//获取焦点
                controller.Select(controller.TextLength, 0);//光标定位到文本最后
                controller.ScrollToCaret();//滚动到光标处
            }
        }
        /// <summary>
        /// 发送log文件到指定邮箱
        /// </summary>
        public static bool UploadLogFile() {
            try {
                D("Error log file uploading.");
                WriteLogFile();
                return LogUpload.Do("god", "error.txt", Const.version);
            } finally {
                if (File.Exists(Directory.GetCurrentDirectory() + @"\error.txt"))
                    File.Delete(Directory.GetCurrentDirectory() + @"\error.txt"); //删除log文件
            }
        }
        /// <summary>
        /// 写日志到文件
        /// </summary>
        public static void WriteLogFile() {
            using (StreamWriter sw = new StreamWriter(@"error.txt", false)) {
                sw.WriteLine(logstorage);
                sw.Close();
            }
        }
    }
}
