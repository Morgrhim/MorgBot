using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("meta")]
    public class ChannelSubscribersMeta
    {
        [JsonProperty("cursor")]
        public ChannelSubscribersCursor Cursor { get; set; }
    }
}
