using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeRenXing.HttpWebClientTest
{
    /// <summary>
    /// Description:简单Http客户端请求类测试
    /// Author:美丽的地球
    /// QQ:1851690435
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebResponseResult httpWebResponseResult = null;
            HttpWebClient httpWebClient = new HttpWebClient();
            httpWebClient.Headers.Add("Referer", "http://localhost");
            httpWebClient.IsTraceEnabled = true;

            //Example No.1 multipart/form-data POST reqeust
            String url = "http://localhost:53090/upload/uploadfile";
            byte[] byteFiles = null;
            using (FileStream fs = new FileStream(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "01.jpg"), FileMode.Open, FileAccess.Read))
            {
                byteFiles = new byte[fs.Length];
                fs.Read(byteFiles, 0, byteFiles.Length);
            }

            httpWebClient.SetField("StorageFile.Title", "title01", true);
            httpWebClient.SetField("StorageFile.Summary", "summary01", true);
            httpWebClient.SetField("filedata", byteFiles, "001.jpg", String.Empty);
            httpWebResponseResult = httpWebClient.Post(url);
            TraceInfo(httpWebResponseResult);

            //Example No.2 application/x-www-form-urlencoded POST reqeust
            url = "http://localhost:53090/passport/logon";
            httpWebClient.SetField("LogonInfo.ValidateCode", "gvzwb");
            httpWebClient.SetField("LogonInfo.User.Username", "sanxia123");
            httpWebClient.SetField("LogonInfo.User.Password", "Yc123703");
            httpWebClient.SetField("LogonInfo.IsPersistentCookie", "false");
            httpWebResponseResult = httpWebClient.Post(url);
            TraceInfo(httpWebResponseResult);

            //Example No.3 GET reqeust
            url = "http://localhost:53090/content/oauth.html";
            httpWebClient.SetField("a", "1");
            httpWebResponseResult = httpWebClient.Get(url);
            TraceInfo(httpWebResponseResult);

            System.Console.ReadKey(true);
        }

        private static void TraceInfo(HttpWebResponseResult httpWebResponseResult)
        {
            System.Console.WriteLine(httpWebResponseResult.RequestTraceInfo);
            System.Console.WriteLine(httpWebResponseResult.ResponseText);
            System.Console.WriteLine("");
        }
    }
}
