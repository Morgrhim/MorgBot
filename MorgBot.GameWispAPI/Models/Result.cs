using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    [JsonObject("result")]
    public class Result
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
