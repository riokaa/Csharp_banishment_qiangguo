using System;
using System.Windows.Forms;

namespace _190320_Banishment移植.BaseLib {
    public class Log {
        public static void D(string log) {
            string output = string.Format("{0} [debug] : {1}", BaseLib.getCurrentTime(), log);
            Console.WriteLine(output);
        }
        public static void I(string log) {
            string output = string.Format("{0} [info] : {1}", BaseLib.getCurrentTime(), log);
            Console.WriteLine(output);
            MainForm.self.MainController.Text += System.Environment.NewLine + output;
        }
        public static void W(string log) {
            string output = string.Format("{0} [warn] : {1}", BaseLib.getCurrentTime(), log);
            Console.WriteLine(output);
            MainForm.self.MainController.Text += System.Environment.NewLine + output;
        }
        public static void E(string log) {
            string output = string.Format("{0} [error] : {1}", BaseLib.getCurrentTime(), log);
            Console.WriteLine(output);
            MainForm.self.MainController.Text += System.Environment.NewLine + output;
        }
        public static void F(string log) {
            string output = string.Format("{0} [fatal] : {1}", BaseLib.getCurrentTime(), log);
            Console.WriteLine(output);
            MainForm.self.MainController.Text += System.Environment.NewLine + output;
            MessageBox.Show(output, "Fatal!");
        }
    }
}
