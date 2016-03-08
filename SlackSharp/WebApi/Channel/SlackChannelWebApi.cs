using SlackSharp.Configuration;
using System.Threading.Tasks;
using SlackSharp.Extensions;


namespace SlackSharp.WebApi.Channel
{
    public class SlackChannelWebApi : SlackWebApi
    {
        public SlackChannelWebApi(ISlackApiConfiguration apiConfiguration) : base(apiConfiguration)
        {
        }

        public async Task<SlackChannelInfoResponse> Info(SlackChannelInfoRequest request)
        {
            var parameters = request.ToPropertyValueDictionary();
            return await Post<SlackChannelInfoResponse>("channels.info", parameters);
        }
    }
}
