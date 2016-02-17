using System.Threading.Tasks;
using SlackSharp.Extensions;

namespace SlackSharp.WebApi.Chat
{
    public class SlackChatWebApi : SlackWebApi
    {
        public SlackChatWebApi(string apiToken, string apiUrl) : base(apiToken, apiUrl)
        {
        }

        public async Task<SlackChatPostMessageResponse> PostMessage(SlackChatPostMessageRequest request)
        {
            var parameters = request.ToPropertyValueDictionary();
            return await Post<SlackChatPostMessageResponse>("chat.postMessage", parameters);
        }
    }
}
