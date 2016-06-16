using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("data")]
    public class SubscriberData2
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("banned")]
        public bool Banned { get; set; }

        [JsonProperty("deactivated")]
        public bool Deactivated { get; set; }

        [JsonProperty("created_at")]
        public bool CreatedAt { get; set; }

        [JsonProperty("links")]
        public SubscriberLinks Links { get; set; }
    }
}
