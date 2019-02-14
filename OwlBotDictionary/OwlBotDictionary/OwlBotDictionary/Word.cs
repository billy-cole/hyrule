using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OwlBotDictionary
{
    public class Word
    {
        [JsonProperty("type")]
        public string Type       { get; set; }

        [JsonProperty("definition")]
        public string Definition { get; set; }

        [JsonProperty("example")]
        public string Example    { get; set; }
    }
}
