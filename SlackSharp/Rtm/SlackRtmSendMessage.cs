namespace SlackSharp.Rtm
{
    public class SlackRtmSendMessage
    {
        public int Id { get; set; }
        public SlackRtmMessageType Type { get; set; }
        public string Channel { get; set; }
        public string Text { get; set; }
    }
}