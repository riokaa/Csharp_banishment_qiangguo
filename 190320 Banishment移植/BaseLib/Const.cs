using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190320_Banishment移植.BaseLib {
    class Const {
        public static string aesKey = "4e72acd42edcb859ec49f60fd1106a50";
        public static string author = "板";
        public static int[] score = new int[5] { 0, 0, 0, 0, 0 };
        public static int[] scoreMax = new int[5] { 1, 6, 6, 8, 10 };
        public static bool settingsAutoClose = false;
        public static bool settingsAutoShutdown = false;
        public static string urlAnnounce = @"http://verify.rayiooo.top/index.php?m=applib&c=appweb&open_new=&a=new_list&list=10001";
        public static string urlPay = @"http://verify.rayiooo.top/index.php?m=applib&c=appweb&a=new_info&id=83";
        public static string urlQGLearnTV = @"https://www.xuexi.cn/4426aa87b0b64ac671c96379a3a8bd26/db086044562a57b441c24f2af1c8e101.html";
        public static string urlQGMain = @"https://www.xuexi.cn/";
        public static string urlQGMyPoints = @"https://pc.xuexi.cn/points/my-points.html";
        public static string version = "v3.0.0";
        public static string versionDate = "2019.3.21";
    }
}
