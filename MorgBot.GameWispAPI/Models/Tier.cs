using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("tier")]
    public class Tier
    {
        [JsonProperty("data")]
        public TierData Data { get; set; }
    }
}
