using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("cursor")]
    public class ChannelSubscribersCursor
    {
        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("prev")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }
}
