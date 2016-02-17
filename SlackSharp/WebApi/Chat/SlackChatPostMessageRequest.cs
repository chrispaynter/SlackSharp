using Newtonsoft.Json;

namespace SlackSharp.WebApi.Chat
{
    public class SlackChatPostMessageRequest
    {
        public string Channel { get; set; }
        public string Text { get; set; }

        [JsonProperty(PropertyName = "is_channel")]
        public bool AsUser { get; set; }

        public string Username { get; set; }

        [JsonProperty(PropertyName = "icon_url")]
        public string IconUrl { get; set; }
    }

}
