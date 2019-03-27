using System;
using System.Text;
using System.Windows.Forms;

namespace Banishment.BaseLib {
    public class Log {
        public static StringBuilder output = new StringBuilder();
        public static void D(string log) {
            string temp = string.Format("{0} [debug] : {1}", Base.GetCurrentTime(), log);
            Console.WriteLine(temp);
            if (Const.debug) {
                output.AppendLine(temp);
                ControllerFlush();
            }
        }
        public static void I(string log) {
            string temp = string.Format("{0} [info] : {1}", Base.GetCurrentTime(), log);
            Console.WriteLine(temp);
            output.AppendLine(temp);
            ControllerFlush();
        }
        public static void W(string log) {
            string temp = string.Format("{0} [warn] : {1}", Base.GetCurrentTime(), log);
            Console.WriteLine(temp);
            output.AppendLine(temp);
            ControllerFlush();
        }
        public static void E(string log) {
            string temp = string.Format("{0} [error] : {1}", Base.GetCurrentTime(), log);
            Console.WriteLine(temp);
            output.AppendLine(temp);
            ControllerFlush();
        }
        public static void F(string log) {
            string temp = string.Format("{0} [fatal] : {1}", Base.GetCurrentTime(), log);
            Console.WriteLine(temp);
            output.AppendLine(temp);
            ControllerFlush();
            MessageBox.Show(temp, "Fatal!");
        }
        public static void ControllerFlush() {
            var controller = MainForm.self.MainController;
            if (controller.InvokeRequired) {
                controller.Invoke(new Action(() => {
                    controller.Text = output.ToString();
                    controller.Focus();//获取焦点
                    controller.Select(controller.TextLength, 0);//光标定位到文本最后
                    controller.ScrollToCaret();//滚动到光标处
                }));
            } else {
                controller.Text = output.ToString();
                controller.Focus();//获取焦点
                controller.Select(controller.TextLength, 0);//光标定位到文本最后
                controller.ScrollToCaret();//滚动到光标处
            }
        }
    }
}
