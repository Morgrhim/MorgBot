using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("twitch")]
    public class ChannelInfoTwitch
    {
        [JsonProperty("data")]
        public ChannelInfoData2 Data { get; set; }
    }
}
