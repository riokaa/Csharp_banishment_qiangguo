using Banishment.BaseLib;
using BanishmentVerifyDll;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Banishment.Modules {
    class WebGetVideoList {
        static int maxTryCount = 10; //videoList请求超时最大请求次数
        public static void Start() {
            Log.D("WebGetVideoList: getting video list from server.");
            string response = HttpRequest.Get(Const.urlVideoList);
            Log.D("WebGetVideoList: response - " + response);
            WebVideoListObject videoListResp;
            try {
                videoListResp = JsonConvert.DeserializeObject<WebVideoListObject>(response);
            } catch (Exception) {
                Log.W(string.Format("WebGetVideoList: 获取视频列表失败: wrong response data![@data={0}]", response));
                maxTryCount--;
                Thread.Sleep(2000);
                if(maxTryCount > 0) {
                    new Thread(Start).Start(); //重新请求
                }
                return;
            }
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
