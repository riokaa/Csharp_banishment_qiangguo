﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BanishmentVerifyDll {
    //class Example {
    //    private void test() {
    //        // Get
    //        var getUrl = "http://localhost:8888?";
    //        HttpRequest.Get(getUrl);

    //        // Post
    //        var postUrl = "http://localhost:8888";
    //        var postObj = new {
    //            username = "DamonZhu",
    //            password = "12345678"
    //        };
    //        var postData = JsonConvert.SerializeObject(postObj);
    //        HttpRequest.Post(postUrl, postData);
    //    }
    //}
    public static class HttpRequest {
        /// <summary>
        /// Http Get Request
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string Get(string url, Dictionary<string, string> param = null) {
            string strGetResponse = string.Empty;
            try {
                var getRequest = CreateHttpRequest(url, "GET", param);
                var getResponse = getRequest.GetResponse() as HttpWebResponse;
                strGetResponse = GetHttpResponse(getResponse, "GET");
            } catch (Exception ex) {
                strGetResponse = ex.Message;
            }
            return strGetResponse;
        }

        /// <summary>
        /// Http Post Request
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postJsonData"></param>
        /// <returns></returns>
        public static string Post(string url, string postJsonData) {
            string strPostReponse = string.Empty;
            try {
                var postRequest = CreateHttpRequest(url, "POST", postJsonData);
                var postResponse = postRequest.GetResponse() as HttpWebResponse;
                strPostReponse = GetHttpResponse(postResponse, "POST");
            } catch (Exception ex) {
                strPostReponse = ex.Message;
            }
            return strPostReponse;
        }

        public static string Post(string url, Dictionary<string, string> param = null) {
            string strPostReponse = string.Empty;
            try {
                var postRequest = CreateHttpRequest(url, "POST", param);
                var postResponse = postRequest.GetResponse() as HttpWebResponse;
                strPostReponse = GetHttpResponse(postResponse, "POST");
            } catch (Exception ex) {
                strPostReponse = ex.Message;
            }
            return strPostReponse;
        }

        private static HttpWebRequest CreateHttpRequest(string url, string requestType, params object[] strJson) {
            HttpWebRequest request = null;
            const string get = "GET";
            const string post = "POST";
            if (string.Equals(requestType, get, StringComparison.OrdinalIgnoreCase)) {
                request = CreateGetHttpWebRequest(url);
            }
            if (string.Equals(requestType, post, StringComparison.OrdinalIgnoreCase)) {
                request = CreatePostHttpWebRequest(url, strJson[0].ToString());
            }
            return request;
        }
        private static HttpWebRequest CreateHttpRequest(string url, string requestType, Dictionary<string, string> param = null) {
            HttpWebRequest request = null;
            const string get = "GET";
            const string post = "POST";
            if (string.Equals(requestType, get, StringComparison.OrdinalIgnoreCase)) {
                if(param != null) {
                    List<string> paramList = new List<string>();
                    foreach (var item in param) {
                        paramList.Add(string.Format("{0}={1}", item.Key, item.Value));
                    }
                    url = url + "?" +string.Join("&", paramList.ToArray());
                }
                request = CreateGetHttpWebRequest(url);
            }
            if (string.Equals(requestType, post, StringComparison.OrdinalIgnoreCase)) {
                string data = string.Empty;
                if(param != null) {
                    List<string> paramList = new List<string>();
                    foreach(var item in param) {
                        paramList.Add(string.Format("{0}={1}", item.Key, item.Value));
                    }
                    data = string.Join("&", paramList.ToArray());
                }
                request = CreatePostHttpWebRequest(url, data);
            }
            return request;
        }

        private static HttpWebRequest CreateGetHttpWebRequest(string url) {
            var getRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            getRequest.Method = "GET";
            getRequest.Timeout = 5000;
            getRequest.ContentType = "text/html;charset=UTF-8";
            getRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            return getRequest;
        }

        private static HttpWebRequest CreatePostHttpWebRequest(string url, string postData) {
            var postRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            postRequest.KeepAlive = false;
            postRequest.Timeout = 5000;
            postRequest.Method = "POST";
            postRequest.ContentType = "application/x-www-form-urlencoded";
            postRequest.ContentLength = postData.Length;
            postRequest.AllowWriteStreamBuffering = false;
            StreamWriter writer = new StreamWriter(postRequest.GetRequestStream(), Encoding.ASCII);
            writer.Write(postData);
            writer.Flush();
            return postRequest;
        }

        private static string GetHttpResponse(HttpWebResponse response, string requestType) {
            var responseResult = "";
            const string post = "POST";
            string encoding = "UTF-8";
            if (string.Equals(requestType, post, StringComparison.OrdinalIgnoreCase)) {
                encoding = response.ContentEncoding;
                if (encoding == null || encoding.Length < 1) {
                    encoding = "UTF-8";
                }
            }
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding))) {
                responseResult = reader.ReadToEnd();
            }
            return responseResult;
        }

        private static string GetHttpResponseAsync(HttpWebResponse response, string requestType) {
            var responseResult = "";
            const string post = "POST";
            string encoding = "UTF-8";
            if (string.Equals(requestType, post, StringComparison.OrdinalIgnoreCase)) {
                encoding = response.ContentEncoding;
                if (encoding == null || encoding.Length < 1) {
                    encoding = "UTF-8";
                }
            }
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding))) {
                responseResult = reader.ReadToEnd();
            }
            return responseResult;
        }
    }
}
