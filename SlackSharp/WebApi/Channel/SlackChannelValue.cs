using System;
using Newtonsoft.Json;

namespace SlackSharp.WebApi.Channel
{
    public class SlackChannelValue
    {
        public string Value { get; set; }
        public string Creator { get; set; }

        [JsonProperty(PropertyName = "last_set")]
        public DateTime LastSet { get; set; }
    }
}
