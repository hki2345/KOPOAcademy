using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    internal class Program
    {
        const string SERVICE_ID = "ncp:sms:kr:307817327735:csharp";
        const string ACCESS_KEY = "6XvWEGyqO8UXKduLqxxL";
        const string SECRET_KEY = "ffEypANFlFtweCtQTxhUAWwQsvtWXxeWvbgCyvdt";

        const string url = "https://sens.apigw.ntruss.com/sms/v2/services/ncp:sms:kr:307817327735:csharp/messages";
        static void Main(string[] args)
        {
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            string signature = MakeSignature(timestamp);
            Console.WriteLine(timestamp);
            Console.WriteLine(signature);

            Dictionary<string, object> body = new Dictionary<string, object>
            {
                ["type"] = "SMS",
                ["from"] = "01040246674",
                ["subject"] = "제목",
                ["content"] = "ㅇㅇ",
                ["messages"] = new List<Dictionary<string, object>>
                {
                    new Dictionary<string, object>{["to"] = "01040246674" }
                },                
            };

        string json = JsonConvert.SerializeObject(body);

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("x-ncp-apigw-timestamp", timestamp.ToString());
            httpWebRequest.Headers.Add("x-ncp-iam-access-key", ACCESS_KEY.ToString());
            httpWebRequest.Headers.Add("x-ncp-apigw-signature-v2", signature.ToString());
            httpWebRequest.Method = "POST";

            using(StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
            }

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string responseJson;
            using (StreamReader streamReader =  new StreamReader(httpWebResponse.GetResponseStream()))
            {
                responseJson = streamReader.ReadToEnd();
            }

            Console.WriteLine(responseJson);
        }

        static string MakeSignature(long timestamp)
        {
            string message = $"POST /sms/v2/services/{SERVICE_ID}/messages\n{timestamp}\n{ACCESS_KEY}";

            HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(SECRET_KEY));
            hmac.Initialize();

            byte[] rawHmac = hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
            return Convert.ToBase64String(rawHmac);
        }
    }
}
