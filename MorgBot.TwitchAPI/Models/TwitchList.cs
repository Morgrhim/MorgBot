using System.Collections.Generic;
using Newtonsoft.Json;
using MorgBot.TwitchAPI.Helpers;

namespace MorgBot.TwitchAPI.Models
{
    [JsonObject(ItemConverterType = typeof(TwitchListConverter))]
    public class TwitchList<T> : TwitchResponse
    {
        public List<T> List { get; set; }
    }
}
