using Newtonsoft.Json;

namespace SlackSharp.OAuth.Models
{
    public class IncomingWebHook
    {
        public string Url { get; set; }
        public string Channel { get; set; }
        public string ConfigurationUrl { get; set; }
    }

    public class Bot
    {
        [JsonProperty(PropertyName = "bot_user_id")]
        public string BotUserId { get; set; }

        [JsonProperty(PropertyName = "bot_access_token")]
        public string BotAccessToken{ get; set; }
    }

    public class OuthAccessResponse
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }
        public string Scope { get; set; }

        public Bot Bot { get; set; }
    }
}
