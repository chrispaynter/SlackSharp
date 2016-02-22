using Newtonsoft.Json;

namespace SlackSharp.WebApi.Users
{
    public class SlackUserProfile
    {
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Title { get; set; }

        public string Skype { get; set; }


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

        [JsonProperty(PropertyName = "image_512")]
        public string Image512 { get; set; }

        [JsonProperty(PropertyName = "image_1024")]
        public string Image1024 { get; set; }

        [JsonProperty(PropertyName = "image_original")]
        public string ImageOriginal { get; set; }

        [JsonProperty(PropertyName = "real_name")]
        public string RealName { get; set; }

        [JsonProperty(PropertyName = "real_name_normalized")]
        public string RealNameNormalized { get; set; }

        public string Email { get; set; }
    }
}
