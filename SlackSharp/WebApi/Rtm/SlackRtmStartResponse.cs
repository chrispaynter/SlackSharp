using System.Collections.Generic;
using Newtonsoft.Json;
using SlackSharp.WebApi.Channel;
using SlackSharp.WebApi.InstantMessage;
using SlackSharp.WebApi.Team;
using SlackSharp.WebApi.Users;

namespace SlackSharp.WebApi.Rtm
{
    public class SlackRtmStartResponse : WebApiResponse
    {
        public string Url { get; set; }
        public SlackTeam Team { get; set; }
        public List<SlackChannel> Channels { get; set; }
        
        public SlackUser Self { get; set; }
        
        [JsonProperty(PropertyName = "ims")]
        public List<SlackInstantMessage> InstantMessages { get; set; }
    }
}
