using Newtonsoft.Json;
namespace SlackSharp.Rtm.Events
{
    public class SlackRtmError
    {
        public string Code { get; set; }

        [JsonProperty(PropertyName = "msg")]
        public string Message { get; set; }
    }

    public class SlackRtmEventError : SlackRtmEvent
    {
        public SlackRtmError Error { get; set; }
    }
}
