using System.Collections.Generic;

namespace SlackSharp.WebApi.Users
{
    public class SlackUsersListResponse : WebApiResponse
    {
        public List<SlackUser> Members { get; set; }
    }
}
