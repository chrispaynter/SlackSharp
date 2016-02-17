using Newtonsoft.Json;

namespace SlackSharp.WebApi.Users
{
    public class SlackUserProfile
    {
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "real_name")]
        public string RealName { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Phone { get; set; }

        [JsonProperty(PropertyName = "image_24")]
        public string Image24 { get; set; }

        [JsonProperty(PropertyName = "image_32")]
        public string Image32 { get; set; }

        [JsonProperty(PropertyName = "image_48")]
        public string Image48 { get; set; }

        [JsonProperty(PropertyName = "image_72")]
        public string Image72 { get; set; }

        [JsonProperty(PropertyName = "image_192")]
        public string Image192 { get; set; }
    }
}
