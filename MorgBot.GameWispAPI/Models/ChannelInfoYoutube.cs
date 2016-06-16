using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("youtube")]
    public class ChannelInfoYoutube
    {
        [JsonProperty("data")]
        public ChannelInfoData3 Data { get; set; }
    }
}
