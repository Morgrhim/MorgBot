﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace MorgBot.TwitchAPI.Models
{
    public class StreamSummary : TwitchResponse
    {
        [JsonProperty("viewers")]
        public long Viewers { get; set; }

        [JsonProperty("channels")]
        public long Channels { get; set; }
    }
}
