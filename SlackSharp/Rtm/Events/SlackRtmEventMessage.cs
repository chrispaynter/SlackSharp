
using Newtonsoft.Json;

namespace SlackSharp.Rtm.Events
{
    public class SlackRtmEventMessage : SlackRtmEvent
    {
        public string Channel { get; set; }

        public string User { get; set; }

        public string Text { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public string TimeStamp { get; set; }
    }
}
