using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("data")]
    public class TierData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
