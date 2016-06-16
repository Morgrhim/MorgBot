using Newtonsoft.Json;

namespace MorgBot.TwitchAPI.Models
{
    [JsonObject("badges")]
    public class Badge
    {
        [JsonProperty("alpha")]
        public string Alpha { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }
}
