﻿using System;
using Newtonsoft.Json;

namespace MorgBot.TwitchAPI.Models
{
    [JsonObject("users")]
    public class User : TwitchResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("_id")]
        public long Id { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("partnered")]
        public bool Partnered { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("notifications")]
        public Notification Notifications { get; set; }
    }
}
