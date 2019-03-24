using _190320_Banishment移植.BaseLib;
using _190320_Banishment移植.NetWork;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace _190320_Banishment移植.WebOptions {
    class WebGetVideoList {
        public static void Start() {
            Log.D("WebGetVideoList: getting video list from server.");
            string response = HttpRequest.Get(Const.urlVideoList);
            Log.D("WebGetVideoList: response - " + response);
            WebVideoListObject videoListResp = JsonConvert.DeserializeObject<WebVideoListObject>(response, new JsonSerializerSettings {
                Error = delegate(object obj, Newtonsoft.Json.Serialization.ErrorEventArgs args) {
                    Log.W("WebGetVideoList: 获取视频列表失败: wrong response data!");
                    args.ErrorContext.Handled = true;
                    return;
                }
            });
            if (!videoListResp.message.Equals("ok")) {
                Log.W("WebGetVideoList: 获取视频列表失败: wrong response message!");
            }
            Log.I("WebGetVideoList: video list got.");
        }
    }
    class WebVideoListObject {
        public int status { get; set; }
        public string message { set; get; }
        public List<WebVideoObject> data { set; get; }
    }
    class WebVideoObject {
        public string Id { get; set; }
        public string date { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }
}
