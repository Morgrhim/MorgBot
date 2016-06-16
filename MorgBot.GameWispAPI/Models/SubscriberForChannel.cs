using System.Collections.Generic;
using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    class SubscriberForChannel
    {
        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("data")]
        public List<SubscriberData> Data { get; set; }
    }
}
