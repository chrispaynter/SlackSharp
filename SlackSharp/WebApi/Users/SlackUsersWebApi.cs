using System.Threading.Tasks;
using SlackSharp.Configuration;

namespace SlackSharp.WebApi.Users
{
    public class SlackUsersWebApi : SlackWebApi
    {
        public SlackUsersWebApi(ISlackApiConfiguration apiConfiguration) : base(apiConfiguration)
        {
        }

        public async Task<SlackUsersListResponse> List()
        {
            return await Post<SlackUsersListResponse>("users.list");
        }
    }
}
