using Newtonsoft.Json;

namespace MorgBot.TwitchAPI.Models
{
    public class RootResult
    {
        [JsonProperty("token")]
        public Token Token { get; set; }
    }
}
