using Banishment.BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banishment.NetWork {
    class Bsphp {
        public static string ApiRequest(string apiName, Dictionary<string, string> param = null) {
            Log.D(string.Format("Bsphp.ApiRequest.ApiName: {0}.", apiName));
            //: stable params
            Dictionary<string, string> dict = new Dictionary<string, string> {
                { "api", apiName },
                { "BSphpSeSsL", BS.sessl },
                { "date", Base.GetCurrentTime() },
                { "md5", "" },
                { "mutualkey", BS.mutualKey },
                { "appsafecode", Base.MD5(Base.GetTimeStamp()) }
            };
            //: merge params
            dict = dict.Concat(param).ToDictionary(k => k.Key, v => v.Value);
            //: compute sign
            List<string> dictList = new List<string>();
            foreach (var item in dict) {
                dictList.Add(string.Format("{0}={1}", item.Key, item.Value));
            }
            string parameter = string.Join("&", dictList.ToArray());
            parameter = Convert.ToBase64String(Encoding.Default.GetBytes(parameter)); //获取Base64编码数据
            string sign = Base.MD5(BS.inSgin.Replace("[KEY]", parameter)).ToLower();
            //: 获取最终parameter和sgin参数(Base64编码传输模式)
            param = new Dictionary<string, string> {
                { "parameter", parameter },
                { "sgin", sign }
            };
            //: http post request
            string response = HttpRequest.Post(BS.reqUrl, param);
            response = Convert.FromBase64String(response).ToString();
            Log.D(string.Format("Bsphp.ApiRequest.Response: {0}.", response));

            //: verify data safe


            //: wrong return temp
            return "";
        }

        public static string UpdateSeSSL() {
            BS.sessl = Base.MD5(BS.machineCode + Base.GetTimeStamp());
            return BS.sessl;
        }
    }
}
