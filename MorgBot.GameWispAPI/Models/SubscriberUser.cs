using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("user")]
    public class SubscriberUser
    {
        [JsonProperty("data")]
        public SubscriberData2 Data { get; set; }
    }
}
