using Banishment.BaseLib;
using Banishment.NetWork;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Banishment.Modules {
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
                return;
            }
            Const.videoList = videoListResp.data;
            Log.I(string.Format("WebGetVideoList: 获取视频列表成功。 [@count={0}]", Const.videoList.Count));
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
