using System;
using Newtonsoft.Json;

namespace MorgBot.TwitchAPI.Models
{
    [JsonObject("subscriptions")]
    public class Subscription
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        // Either user or channel is null.
        // There are two types of subscription:
        // User subscriptions and Channel subscriptions

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("channel")]
        public Channel Channel { get; set; }
    }
}
