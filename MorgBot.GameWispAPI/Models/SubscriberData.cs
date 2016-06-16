using System;
using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("data")]
    public class SubscriberData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subscribed_at")]
        public DateTime SubscribedAt { get; set; }

        [JsonProperty("tier_id")]
        public string TierId { get; set; }

        // May or may not be null, only populates on channel/subscriber-for-channel
        [JsonProperty("tier")]
        public Tier Tier { get; set; }

        [JsonProperty("user")]
        public SubscriberUser User { get; set; }
    }
}
