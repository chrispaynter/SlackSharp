using System.Threading.Tasks;
using SlackSharp.Configuration;
using SlackSharp.Extensions;

namespace SlackSharp.WebApi.Chat
{
    public class SlackChatWebApi : SlackWebApi
    {
        public SlackChatWebApi(ISlackApiConfiguration apiConfiguration) : base(apiConfiguration)
        {
        }

        public async Task<SlackChatPostMessageResponse> PostMessage(SlackChatPostMessageRequest request)
        {
            var parameters = request.ToPropertyValueDictionary();
            return await Post<SlackChatPostMessageResponse>("chat.postMessage", parameters);
        }
    }
}
