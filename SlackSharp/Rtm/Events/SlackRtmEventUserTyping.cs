namespace SlackSharp.Rtm.Events
{
    public class SlackRtmEventUserTyping : SlackRtmEvent
    {
        public string Channel { get; set; }
        public string User { get; set; }
    }
}
