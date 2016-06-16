using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("links")]
    public class SubscriberLinks
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
