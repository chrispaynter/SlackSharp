using System.Threading.Tasks;
using SlackSharp.Configuration;

namespace SlackSharp.WebApi.Rtm
{
    public class SlackRtmWebApi : SlackWebApi
    {
        public SlackRtmWebApi(ISlackApiConfiguration apiConfiguration) : base(apiConfiguration)
        {
        }

        public async Task<SlackRtmStartResponse> Start()
        {
            return await Post<SlackRtmStartResponse>("rtm.start");
        }
    }
}
