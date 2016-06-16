using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("data")]
    public class ChannelInfoData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("owner_user_id")]
        public long OwnerUserId { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("deactivated")]
        public bool Deactivated { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("links")]
        public ChannelInfoLinks Links { get; set; }

        [JsonProperty("twitch")]
        public ChannelInfoTwitch Twitch { get; set; }

        [JsonProperty("youtube")]
        public ChannelInfoYoutube Youtube { get; set; }
    }
}
