using System.Collections.Generic;
using System.Threading.Tasks;
using SlackSharp.Configuration;

namespace SlackSharp.WebApi.InstantMessage
{
    public class SlackInstantMessageWebApi : SlackWebApi
    {
        public SlackInstantMessageWebApi(ISlackApiConfiguration apiConfiguration) : base(apiConfiguration)
        {
        }

        public async Task<SlackInstantMessageOpenResponse> Open(string user)
        {
            var parameters = new Dictionary<string, string>() { {"user", user } };
            return await Post<SlackInstantMessageOpenResponse>("im.open", parameters);
        }
    }
}
