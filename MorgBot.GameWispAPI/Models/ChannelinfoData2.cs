using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("data")]
    public class ChannelInfoData2
    {
        [JsonProperty("twitch_id")]
        public string TwitchId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("partnered")]
        public bool Partnered { get; set; }
    }
}
