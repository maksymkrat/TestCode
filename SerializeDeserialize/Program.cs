// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Newtonsoft.Json;
using SerializeDeserialize;

// var jsonStr = $@"{{
//             ""discount"": 0,
//             ""amount"": 0,
//             ""items"": {{
//                         {{
//                             ""id"": 123,
//                             ""name"": ""name1"",
//                             ""description"" : ""description1"",
//                             ""price"": 12
//                         }},
//                         {{
//                             ""id"": 456,
//                             ""name"": ""name2"",
//                             ""description"": ""description2"",
//                             ""price"": 45
//                         }}
//               }}
//             }}";

var jsonStr = @"{
            'discount': 0,
            'amount': 0,
            'items': [
                        {
                            'id': 123,
                            'name': 'name1',
                            'description' : 'description1',
                            'price': 12
                        },
                        {
                            'id': 456,
                            'name': 'name2',
                            'description': 'description2',
                            'price': 45
                        }
              ]
            }";

Console.WriteLine(jsonStr);

// ReceiptModel receipt = JsonSerializer.Deserialize<ReceiptModel>(jsonStr);

// var data = Newtonsoft.Json.JsonConvert.DeserializeObject<ReceiptModel>(jsonStr);

ReceiptModel data = JsonConvert.DeserializeObject<ReceiptModel>(jsonStr);
var x = data;
