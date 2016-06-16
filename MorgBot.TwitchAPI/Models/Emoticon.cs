using System.Collections.Generic;
using Newtonsoft.Json;

namespace MorgBot.TwitchAPI.Models
{
    [JsonObject("emoticons")]
    public class Emoticon
    {
        [JsonProperty("regex")]
        public string Regex { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }
    }
}
