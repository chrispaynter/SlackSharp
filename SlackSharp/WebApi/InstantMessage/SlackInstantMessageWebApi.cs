using System.Collections.Generic;
using System.Threading.Tasks;

namespace SlackSharp.WebApi.InstantMessage
{
    public class SlackInstantMessageWebApi : SlackWebApi
    {
        public SlackInstantMessageWebApi(string apiToken, string apiUrl) : base(apiToken, apiUrl)
        {
        }

        public async Task<SlackInstantMessageOpenResponse> Open(string user)
        {
            var parameters = new Dictionary<string, string>() { {"user", user } };
            return await Post<SlackInstantMessageOpenResponse>("im.open", parameters);
        }
    }
}
