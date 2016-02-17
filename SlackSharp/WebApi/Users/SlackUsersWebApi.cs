using System.Threading.Tasks;

namespace SlackSharp.WebApi.Users
{
    public class SlackUsersWebApi : SlackWebApi
    {
        public SlackUsersWebApi(string apiToken, string apiUrl) : base(apiToken, apiUrl)
        {
        }

        public async Task<SlackUsersListResponse> List()
        {
            return await Post<SlackUsersListResponse>("users.list");
        }
    }
}
