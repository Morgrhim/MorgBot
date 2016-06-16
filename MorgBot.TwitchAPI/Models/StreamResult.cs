using Newtonsoft.Json;

namespace MorgBot.TwitchAPI.Models
{
    public class StreamResult : TwitchResponse
    {
        [JsonProperty("stream")]
        public Stream Stream { get; set; }
    }
}
