using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SlackSharp.WebApi.InstantMessage;
using SlackSharp.WebApi.Users;

namespace SlackSharp.WebApi.Channel
{
    public class SlackChannel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        [JsonProperty(PropertyName = "is_channel")]
        public bool IsChannel { get; set; }

        public string Created { get; set; }

        public string Creator { get; set; }

        [JsonProperty(PropertyName = "is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty(PropertyName = "is_general")]
        public bool IsGeneral { get; set; }

        public List<string> Members { get; set; }

        public SlackChannelValue Topic { get; set; }

        public SlackChannelValue Purpose { get; set; }

        [JsonProperty(PropertyName = "is_member")]
        public bool IsMember { get; set; }

        public SlackInstantMessage Latest { get; set; }

        [JsonProperty(PropertyName = "unread_count")]
        public int UnreadCount { get; set; }

        [JsonProperty(PropertyName = "unread_count_display")]
        public int UnreadCountDisplay { get; set; }
    }
}
