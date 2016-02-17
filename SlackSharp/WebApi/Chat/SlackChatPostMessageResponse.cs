using SlackSharp.WebApi.InstantMessage;

namespace SlackSharp.WebApi.Chat
{
    public class SlackChatPostMessageResponse : WebApiResponse
    {
        public string Channel { get; set; }

        //[JsonProperty(PropertyName = "ts")]
        //public DateTime TimeStamp { get; set; }

        public SlackInstantMessage Message { get; set; }
    }
}
