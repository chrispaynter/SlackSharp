using System.Threading.Tasks;

namespace SlackSharp.WebApi.Rtm
{
    public class SlackRtmWebApi : SlackWebApi
    {
        public SlackRtmWebApi(string apiToken, string apiUrl) : base(apiToken, apiUrl)
        {
        }

        public async Task<SlackRtmStartResponse> PostMessage()
        {
            return await Post<SlackRtmStartResponse>("rtm.start");
        }
    }
}
