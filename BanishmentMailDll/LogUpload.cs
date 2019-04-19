using System.IO;

namespace BanishmentMailDll {
    public class LogUpload {
        public static bool Do(string banIsWhat, string fileName, string version="v") {
            //获得各种参数，不需要的用空字符串
            string smtpServer = "smtp.126.com";//163邮箱的smtp服务器 
            int port = 25;//端口
            string mailFrom = "qwedcvbhuiop@126.com";//发件人邮箱 
            string pwd = "banis1" + banIsWhat; //密码
            string mailTo = "ban_san@163.com";//收件人邮箱,多个用户用逗号隔开
            string mailCC = "";//抄送人,多个用户用逗号隔开
            string mailBcc = "";//密送
            string mailSubject = string.Format("Banishment {0} 异常日志上报", version);//主题
            string mailContent = "板神强无敌。";//内容
            string path = Directory.GetCurrentDirectory() + "\\" + fileName;//附件
            return EmailHelper.SendEmail(smtpServer, port, mailFrom, pwd, mailTo, mailCC, mailBcc, mailSubject, mailContent, path);
        }
    }
}
