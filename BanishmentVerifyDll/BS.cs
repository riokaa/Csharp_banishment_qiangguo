using BanishmentBaseDll;

namespace BanishmentVerifyDll {
    public class BS {
        public static string reqUrl = @"http://verify.rayiooo.top/AppEn.php?appid=10000000&m=a1a7c60094c319355377aa90defb0d01";  //api请求url
        public static string reqUrlCoode = @"http://verify.rayiooo.top/index.php?m=coode&sessl=";
        public static string mutualKey = @"ec46841638311d78e68b3078b5f1ed15";  //通信认证key
        public static string dataEnKey = @"qVHXTCQFIxsvCch92u";
        public static string inSgin = @"[KEY].*?板酱[KEY]banish!";
        public static string outSgin = @"[KEY].*?大喵[KEY]ment!";
        public static string machineCode = Base.MD5(Base.GetMac());  //机器码
        public static string sessl = Bsphp.UpdateSeSSL();
        public static int status = -1;  //登录状态,1011登陆成功
        public static string user = "";
        public static string pwd = "";
        public static string vipDate = "";
        public static bool vip = false;  //是否是vip
    }
}
