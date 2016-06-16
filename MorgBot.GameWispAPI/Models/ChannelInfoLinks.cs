using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("links")]
    public class ChannelInfoLinks
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
