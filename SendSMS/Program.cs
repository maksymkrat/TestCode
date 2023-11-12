// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;

namespace SendSMS
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        public static void Main(string[] args)
        {
            string url = "https://sms-fly.ua/api/v2/api.php";
            HttpWebRequest httpRequest = (HttpWebRequest) WebRequest.Create(url);
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json;";
            //httpRequest.Headers["Authorization"] = "CQqJqZ4m6MnDYH18DK06ds5rqRtXptde";
            
            string authKey = "CQqJqZ4m6MnDYH18DK06ds5rqRtXptde";
            string smsText = "call me back urgently 0975877904";
            string phoneNumber = "380 96 426 84 84";
            // string data = $@"{{ 
            //                         ""auth"": {{
            //                         ""key"": ""{authKey}""}},
            //                     ""action"": ""SENDMESSAGE"",
            //                     ""data"": {{
            //                         ""recipient"": ""{phoneNumber}"",
            //                         ""channels"": [""sms""],
            //                         ""sms"": {{
            //                             ""source"": ""InfoCentr"",
            //                             ""ttl"": 5,
            //                             ""text"": ""{smsText}""
            //                         }}
            //                     }}
            //                 }}";
            // StringBuilder stringBuilder = new StringBuilder();
            // string line;
            // using (StreamReader sr = new StreamReader("D:\\C#\\Projects\\TestCode\\SendSMS\\data.txt"))
            // {    
            //     line = sr.ReadLine();
            //     while (line !=null)
            //     {
            //         stringBuilder.Append(line);
            //         line = sr.ReadLine();
            //     }  
            // }
            //
            // string data = stringBuilder.ToString();
            SmsModel smsModel = new SmsModel();
            smsModel.auth.key = authKey;
            smsModel.data.recipient = phoneNumber;
            smsModel.data.sms.source = "InfoCentr";
            smsModel.data.sms.ttl = 100;
            smsModel.data.sms.text = "call me back urgently 0975877904";
            //string jsonData = JsonSerializer.Serialize<SmsModel>(smsModel);
            string jsonData = JsonConvert.SerializeObject(smsModel);
            Console.WriteLine("dsf");
             using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
             {
                 streamWriter.Write(jsonData);
             }
             
             var httpResponse = (HttpWebResponse) httpRequest.GetResponse();
             using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
             {
                 var result = streamReader.ReadToEnd();
             
                 Console.WriteLine(result);
             }
            
             Console.WriteLine(httpResponse.StatusCode == HttpStatusCode.OK);
        }
        
        
        private class SmsModel
        {
            
            public Auth auth { get; set; }
            public string action { get; set; } = "SENDMESSAGE";
            public Data data { get; set; }

            public SmsModel()
            {
                auth = new Auth();
                data = new Data();
            }
        }
        private class Auth
        {
            public string key { get; set; }
        }
        private class Data 
        {
            public string recipient { get; set; }
            public IList<string> channels { get; set; } = new List<string>() {"sms"};
            public Sms sms { get; set; }

            public Data()
            {
                sms = new Sms();
            }
            
        }
        private class Sms
        {   
            public string source { get; set; }
            public int ttl { get; set; } // message lifetime in minutes
            public string text { get; set; }
        }
    }
    
   
}
