using System;
using System.Net.NetworkInformation;
using System.Text;

namespace Banishment.BaseLib {
    class Base {
        public static string GetCurrentTime() {
            return DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string GetMac() {
            try {
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface ni in interfaces) {
                    string mac = BitConverter.ToString(ni.GetPhysicalAddress().GetAddressBytes());
                    Log.D("Mac address got: " + mac);
                    return mac;
                }
            } catch (Exception) {
                Log.E("Mac address not found.");
            }
            return "00-00-00-00-00-00";
        }

        public static string GetTimeStamp() {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long timeStamp = (long)(DateTime.Now - startTime).TotalSeconds;
            return timeStamp.ToString();
        }

        public static string MD5(string str) {
            System.Security.Cryptography.MD5 md5Hasher = System.Security.Cryptography.MD5.Create();
            return Convert.ToBase64String(md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }
    }
}
