using System;
using Newtonsoft.Json;
using MorgBot.TwitchAPI.Enums;

namespace MorgBot.TwitchAPI.Models
{
    public class TwitchResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("_total")]
        public long Total { get; set; }

        public TwitchResponse() { }

        public State GetState()
        {
            switch (Status)
            {
                case 204:
                    return State.Success;
                case 404:
                    return State.Not_Found;
                case 422:
                    return State.Failed;
                case 503:
                    return State.Failed;
                default:
                    return State.Failed;
            }
        }
    }
}
