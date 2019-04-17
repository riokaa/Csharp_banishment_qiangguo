using BanishmentBaseDll;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BanishmentVerifyDll {
    public static class Bsphp {
        public static Dictionary<string, string> StatusCode;

        static Bsphp() {
            initStatusDic();
        }
        private static string ApiRequest(string apiName, Dictionary<string, string> param = null) {
            //Log.D(string.Format("Bsphp.ApiRequest.ApiName: {0}.", apiName));
            //: stable params
            if(param == null) {
                param = new Dictionary<string, string>();
            }
            string appsafecode = Base.MD5(Base.GetTimeStamp());
            Dictionary<string, string> dict = new Dictionary<string, string> {
                { "api", apiName },
                { "BSphpSeSsL", BS.sessl },
                { "date", Base.GetCurrentTime() },
                { "md5", "" },
                { "mutualkey", BS.mutualKey },
                { "appsafecode", appsafecode }
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
            //Log.D(string.Format("Bsphp.ApiRequest.parameter: {0}", parameter));
            //Log.D(string.Format("Bsphp.ApiRequest.inSginReplace: {0}", BS.inSgin.Replace("[KEY]", parameter)));
            string sign = Base.MD5(BS.inSgin.Replace("[KEY]", parameter)).ToLower();
            //: 获取最终parameter和sgin参数(Base64编码传输模式)
            param = new Dictionary<string, string> {
                { "parameter", parameter },
                { "sgin", sign }
            };
            //: http post request
            string response = HttpRequest.Post(BS.reqUrl, param);

            response = Encoding.UTF8.GetString(Convert.FromBase64String(response));
            //Log.D(string.Format("Bsphp.ApiRequest.Response: {0}.", response));

            //: verify data safe
            try {
                if (!response.StartsWith("{\"response")) {
                    return "";
                }
                JsonReturn respJson = JsonConvert.DeserializeAnonymousType(response, new JsonReturn());
                //判断 appsafecode 是否与发出时一致
                if (!respJson.response.appsafecode.Equals(appsafecode)) { 
                    //Log.W("Api数据包被劫持。");
                }
                //返回签名验证
                //data ＋ date ＋ unix ＋ microtime ＋ appsafecode
                string sSginReturn = respJson.response.data + respJson.response.date + respJson.response.unix + respJson.response.microtime + respJson.response.appsafecode;
                //服务器返回签名KEY设置
                string serverKeyreturn = BS.outSgin.Replace("[KEY]", sSginReturn);
                //签名值
                string sginMd5return = Base.MD5(serverKeyreturn);
                if (!sginMd5return.Equals(respJson.response.sgin)) {
                    //Log.W("Api请求 sgin 签名验证失败。");
                    return "Api请求 sgin 签名验证失败。";
                } else {
                    return respJson.response.data; //返回正确数据包
                }
            } catch (Exception ex) {
                //Log.E(ex.Message);
                return "";
            }
        }

        //初始化状态查询字典
        private static void initStatusDic() {
            StatusCode = new Dictionary<string, string> {
                { "1000", "用户已经存在。请选择其他！" },
                { "1001", "你选择用户名可以使用！" },
                { "1002", "2次密码输入不一致！" },
                { "1003", "账号长度错误限制 3-15位" },
                { "1004", "账号格式错误,只能选择 26位字母+数字和_下滑线" },
                { "1005", "恭喜你注册成功！" },
                { "1006", "账号注册失败,你要注册账号可能被抢注了." },
                { "1007", "密码长度限制 3-15位数" },
                { "1008", "账号错误" },
                { "1009", "密码错误" },
                { "1010", "登陆账号不存在" },
                { "1011", "登陆成功" },
                { "1012", "密码错误" },
                { "1013", "登陆失败" },
                { "1014", "QQ号错误" },
                { "1015", "邮箱错误" },
                { "1016", "手机号码错误" },
                { "1017", "保存成功" },
                { "1018", "保存失败" },
                { "1019", "不能输入空格" },
                { "1020", "请输入密保问题或者答案" },
                { "1021", "账号已经被冻结禁止登陆" },
                { "1022", "记录查询失败" },
                { "1023", "你的密保信息已经填写" },
                { "1024", "密保信息添加成功" },
                { "1025", "密保添加失败" },
                { "1026", "密码不能包含空格" },
                { "1027", "请输入旧密码" },
                { "1028", "旧密码不能和新密码一致" },
                { "1029", "密码修改失败" },
                { "1030", "旧密码不正确,请重新输入" },
                { "1031", "密码修改成功" },
                { "1032", "表单信息不能为空,请返回填写" },
                { "1033", "密码已经成功通过密保信息修改" },
                { "1034", "密保信息错误" },
                { "1035", "密码找回失败" },
                { "1036", "验证码不能为空" },
                { "1037", "验证码正确" },
                { "1038", "验证码错误" },
                { "1039", "检测账号不能为空" },
                { "1040", "账号不能包含空格" },
                { "1041", "长时空闲超时执行正常" },
                { "1042", "长时空闲超时执行异常" },
                { "1043", "账号不存在" },
                { "1044", "账号已经被冻结禁止登陆" },
                { "1045", "登陆超时,由于你长时间不停留请重新登陆" },
                { "1046", "你在别处已经登陆,被迫登出！" },
                { "1047", "已经登陆" },
                { "1048", "你需要登陆才可以访问" },
                { "1049", "没有登录或登录已超时请登陆,在继续你的操作！" },
                { "1050", "密保不能少于4字符" },
                { "1051", "密保信息未填写" },
                { "1052", "充值账号不能为空" },
                { "1053", "充值卡号不能为空" },
                { "1054", "充值卡密码不能为空" },
                { "1055", "充值账号不能包含空格" },
                { "1056", "充值卡号不能包含空格" },
                { "1057", "充值卡密码不能包含空格" },
                { "1058", "充值卡号或充值卡密码错误" },
                { "1059", "充值的用户账号不存在" },
                { "1060", "充值卡账号密码错误或者不存在" },
                { "1061", "用户没有使用过要充值软件,拒绝充值" },
                { "1062", "激活成功,赶快去使用吧！" },
                { "1063", "充值失败！" },
                { "1064", "充值卡已经充值过了" },
                { "1065", "你留言和反馈我们已经收到,谢谢你的支持" },
                { "1066", "提交留言失败" },
                { "1067", "请输入标题" },
                { "1068", "请输入留言内容" },
                { "1069", "激活成功,请在次验证就可以使用了！" },
                { "1070", "添加失败" },
                { "1071", "糟糕卡串已经存在了" },
                { "1072", "还没有存在" },
                { "1073", "卡串不存在或者错误" },
                { "1074", "你使用激活串已到期作废！" },
                { "1075", "卡串已经存在,无法激活" },
                { "1076", "car执行错误" },
                { "1077", "请检查卡串号或者密码错误！" },
                { "1078", "你使用权已经被冻结,无法验证！" },
                { "1079", "验证失败请重新验证,或是否已经登陆" },
                { "1080", "验证成功" },
                { "1081", "登录验证成功！" },
                { "1082", "你的使用期已到,请购卡在使用" },
                { "1083", "没有查询到用户信息" },
                { "1084", "该用户不是使用本软件的" },
                { "1085", "用户已经被冻结" },
                { "1086", "卡串或者验证串已经被冻结,无法继续。" },
                { "1087", "帐号已经到期请充值在使用。" },
                { "1088", "请输入一个邮箱作为你的帐号" },
                { "1089", "恭喜你注册成功,赶快去你邮箱把你帐号激活吧！" },
                { "1090", "密保邮箱不能为空！" },
                { "1091", "密保邮箱格式不正确,请重新输入！" },
                { "1092", "QQ号不能为空！" },
                { "1093", "QQ号格式输入不正确,请重新输入！" },
                { "1094", "你的帐号还没激活,现在已经有一封激活邮件发到你注册邮箱上,赶快去激活吧！" },
                { "5000", "无法接收到GET数据包" },
                { "5001", "无法接收到POST数据包" },
                { "5002", "数据包内出现系统屏蔽字符串" },
                { "5003", "数据包已经过期,拒绝接收" },
                { "5004", "接口不存在,连接失败" },
                { "5005", "软件连接号错误,访问软件不存在" },
                { "5006", "软件MD5验证失败" },
                { "5007", "非法的请求,身份验证失败！" },
                { "5008", "欢迎你首次使用！,请重新登陆." },
                { "5009", "绑定特征码,已经有人绑定过了,不能重复绑定,不能登陆" },
                { "5010", "当前绑定特征已经有人绑定了" },
                { "5011", "账号注册成功,当前机器特征已经有人绑定" },
                { "5012", "当前特征已经有人绑定,无法在绑定" },
                { "5013", "绑定成功！" },
                { "5014", "绑定失败,请重试！" },
                { "5015", "绑定特征不能为空" },
                { "5016", "已经绑定了,不需要在绑定" },
                { "5017", "使用软件不属于登陆模式" },
                { "5018", "当前卡串已经到期,无法解除绑定" },
                { "5019", "解除绑定将到期,无法解除绑定" },
                { "5020", "解除绑定失败,请重试或者联系相关人员解决" },
                { "5021", "解除绑定成功,已经扣除对应时间" },
                { "5022", "当前的卡串已经解除绑定,无须在解除绑定,请直接绑定就可以" },
                { "5023", "绑定KEY不能为空" },
                { "5024", "恭喜你！绑定成功" },
                { "5025", "绑定失败,当前卡串已经绑定key,必须解除绑定才能在绑定" },
                { "5026", "账号登录超时,由于你长时间没有操作请种新登录" },
                { "5027", "登录状态更新失败！" },
                { "5028", "登录状态更新成功！" },
                { "5029", "帐号没有到期！" },
                { "5030", "登录帐号已经到期！" },
                { "5031", "执行正常" },
                { "5032", "扣点模式之扣点执行失败" },
                { "5033", "账号已被冻结" },
                { "9980", "用户VIP到期" },
                { "BSPHP_940006", "AppID md5参数错误 不能为空！" },
                { "BSPHP_940007", "AppID md5参数错误！服务器地址不正确 " },
                { "BSPHP_940008", "通信认证Key不能为空！" },
                { "BSPHP_940009", "通信认证Key验证失败！" },
                { "BSPHP_940010", "BSphpSeSsL连接串不可为空！" }
            };
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <param name="pwda"></param>
        /// <param name="pwdb"></param>
        /// <param name="img">验证码</param>
        /// <returns></returns>
        public static string ChangePassword(string user, string pwd, string pwda, string pwdb, string img = "") {
            Dictionary<string, string> req = new Dictionary<string, string> {
                { "user", user },
                { "pwd", pwd },
                { "pwda", pwda },
                { "pwdb", pwdb },
                { "img", img }
            };
            return ApiRequest("password.lg", req);
        }
        /// <summary>
        /// 取用户登录状态信息
        /// </summary>
        /// <returns></returns>
        public static string GetLoginInfo() {
            return ApiRequest("lginfo.lg");
        }
        /// <summary>
        /// 取用户信息
        /// </summary>
        /// <param name="info">用户名称/到期时间/是否到期</param>
        /// <returns></returns>
        public static string GetUserInfo(string info) {
            string reqInfo = "";
            switch (info) {
                case "用户名称":
                    reqInfo = "UserName";
                    break;
                case "到期时间":
                    reqInfo = "UserVipDate";
                    break;
                case "是否到期":
                    reqInfo = "UserVipWhether";
                    break;
            }
            Dictionary<string, string> req = new Dictionary<string, string> {
                { "info", reqInfo }
            };
            return ApiRequest("getuserinfo.lg", req);
        }
        /// <summary>
        /// 获取软件版本号
        /// </summary>
        /// <returns></returns>
        public static string GetVersion() {
            return ApiRequest("v.in");
        }
        /// <summary>
        /// 心跳包
        /// </summary>
        /// <returns></returns>
        public static string Heart() {
            return ApiRequest("timeout.lg");
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static string Login(string user, string pwd) {
            Dictionary<string, string> req = new Dictionary<string, string> {
                { "user", user },
                { "pwd", pwd },
                { "maxoror", BS.machineCode }
            };
            return ApiRequest("login.lg", req);
        }
        /// <summary>
        /// 注销登陆
        /// </summary>
        /// <returns></returns>
        public static string Logout() {
            return ApiRequest("cancellation.lg");
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <param name="pwdb"></param>
        /// <param name="email"></param>
        /// <param name="coode"></param>
        /// <returns></returns>
        public static string Register(string user, string pwd, string pwdb, string email, string coode) {
            Dictionary<string, string> req = new Dictionary<string, string> {
                { "user", user },
                { "pwd", pwd },
                { "pwdb", pwdb },
                { "mail", email },
                { "coode", coode }
            };
            return ApiRequest("registration.lg", req);
        }
        /// <summary>
        /// 刷新sessl码
        /// </summary>
        /// <returns></returns>
        public static string UpdateSeSSL() {
            BS.sessl = Base.MD5(BS.machineCode + Base.GetTimeStamp());
            //Log.D(string.Format("Bsphp.UpdateSeSSL.sessl: {0}", BS.sessl));
            return BS.sessl;
        }
        /// <summary>
        /// Vpi充值续期
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <param name="userset">是否需要验证密码,输入值1即要验证密码,防止充值错误给了别人,否则不需要验证密码是否正确就可以充值</param>
        /// <param name="ka"></param>
        /// <param name="kapwd"></param>
        /// <returns></returns>
        public static string VipChong(string user, string pwd, int userset, string ka, string kapwd) {
            Dictionary<string, string> req = new Dictionary<string, string> {
                { "user", user },
                { "userpwd", pwd },
                { "userset", userset.ToString() },
                { "ka", ka },
                { "pwd", kapwd }
            };
            return ApiRequest("chong.lg", req);
        }
    }

    //JSON数据结构定义
    public class JsonReturn {
        public JsonData response;
    }
    public class JsonData {
        public string data;
        public string date;
        public string unix;
        public string microtime;
        public string appsafecode;
        public string sgin;
    }
}
