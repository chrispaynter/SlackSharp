using SlackSharp.WebApi.Channel;

namespace SlackSharp.WebApi.InstantMessage
{
    public class SlackInstantMessageOpenResponse : WebApiResponse
    {
        public SlackChannel Channel { get; set; }
    }
}
