using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    public class ChannelInfo
    {
        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("data")]
        public ChannelInfoData Data { get; set; }
    }
}
