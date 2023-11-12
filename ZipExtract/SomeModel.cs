using System;
using System.Text.Json.Serialization;

namespace ZipExtract
{
    [Serializable]
    public class SomeModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("age")]
        public string Age { get; set; }
    }
}