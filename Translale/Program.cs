using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Translale
{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();

        public static void Main(string[] args)
        {
            var url = "https://dev-api.itranslate.com/translation/v2/";

            var httpRequest = (HttpWebRequest) WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Headers["Authorization"] = "Bearer 603160b7-cee1-4c13-bcd7-37420b55211d";
            httpRequest.ContentType = "application/json;";

            string translateWord = "hello";

            var data = $@"{{
                         ""source"": {{""dialect"": ""en"", ""text"": ""{translateWord}""}},
                         ""target"": {{""dialect"": ""uk""}}
                            }}";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse) httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                Console.WriteLine(result);
            }


            Console.WriteLine(httpResponse.StatusCode);
            Console.WriteLine("³³³³³");
        }
    }


    public class Translate
    {
        public Source Source { get; set; }
        public Target Target { get; set; }
    }

    public class Source
    {
        public string Dialect { get; set; }
        public string Text { get; set; }
    }


    public class Target
    {
        public string Dialect { get; set; }
        public string Text { get; set; }
    }
}


// const res = await fetch("https://libretranslate.com/translate", {
//     method: "POST",
//     body: JSON.stringify({
//         q: "translate",
//         source: "en",
//         target: "uk",
//         format: "text"
//     }),
//     headers: { "Content-Type": "application/json" }
// });
//
// console.log(await res.json());


// curl --location --request POST 'https://dev-api.itranslate.com/translation/v2/'
//     --header 'Authorization: Bearer 603160b7-cee1-4c13-bcd7-37420b55211d'
//     --header 'Content-Type: application/json' --data-raw '{
// "source": {"dialect": "en", "text": "Hello World"},
// "target": {"dialect": "es"}
// }'


// var url = "https://reqbin.com/echo/post/json";
//
// var httpRequest = (HttpWebRequest) WebRequest.Create(url);
// httpRequest.Method = "POST";
//
// // httpRequest.Headers["Authorization"] = "Bearer mt0dgHmLJMVQhvjpNXDyA83vA_PxH23Y";
// httpRequest.ContentType = "application/json";
//
// var data = @"{
//                           ""Id"": 12345,
//                           ""Customer"": ""John Smith"",
//                           ""Quantity"": 1,
//                           ""Price"": 10.00
//                         }";
//
// using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
// {
//     streamWriter.Write(data);
// }
//
// var httpResponse = (HttpWebResponse) httpRequest.GetResponse();
// using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
// {
//     var result = streamReader.ReadToEnd();
// }
//
// Console.WriteLine(httpResponse.StatusCode);