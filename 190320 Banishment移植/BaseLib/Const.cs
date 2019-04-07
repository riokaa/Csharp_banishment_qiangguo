using Banishment.Modules;
using System.Collections.Generic;

namespace Banishment.BaseLib {
    class Const {
        public static string aesKey = "4e72acd42edcb859ec49f60fd1106a50";
        public static string author = "板";
        public static bool debug = false;
        public static int[] score = new int[5] { 0, 0, 0, 0, 0 };
        public static int[] scoreMax = new int[5] { 1, 6, 6, 6, 6 };
        public static bool settingsAutoClose = false;
        public static bool settingsAutoShutdown = false;
        public static bool settingsNoVoice = false;
        public static string urlAnnounce = @"http://verify.rayiooo.top/index.php?m=applib&c=appweb&open_new=&a=new_list&list=10001";
        public static string urlPay = @"http://verify.rayiooo.top/index.php?m=applib&c=appweb&a=new_info&id=83";
        public static string urlQGLearnTV = @"https://www.xuexi.cn/4426aa87b0b64ac671c96379a3a8bd26/db086044562a57b441c24f2af1c8e101.html";
        public static string urlQGMain = @"https://www.xuexi.cn/";
        public static string urlQGMyPoints = @"https://pc.xuexi.cn/points/my-points.html";
        public static string urlUpdateXml = @"http://api.rayiooo.top/banishment/update/{0}";
        public static string urlVideoList = @"http://api.rayiooo.top/banishment/getVideoList.php";
        public static List<WebVideoObject> videoList;
        public static string version = "v3.1.0";
        public static string versionDate = "2019.4.7";
    }
}
