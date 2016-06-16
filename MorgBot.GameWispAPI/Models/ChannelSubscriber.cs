using System.Collections.Generic;
using Newtonsoft.Json;

namespace MorgBot.GameWispAPI.Models
{
    public class ChannelSubscriber
    {
        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("data")]
        public List<SubscriberData> Data { get; set; }

        [JsonProperty("meta")]
        public ChannelSubscribersMeta Meta { get; set; }
    }
}
