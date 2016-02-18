using Newtonsoft.Json;

namespace SlackSharp.WebApi.Team
{
    public class SlackTeam
    {
        public string Id { get; set; }

        public string Name { get; set; }
        
        public string Domain { get; set; }

        [JsonProperty(PropertyName = "email_domain")]
        public string EmailDomain { get; set; }
        
        public SlackTeamIcon Icon { get; set; }
    }
    
    public class SlackTeamIcon
    {
        [JsonProperty(PropertyName = "image_34")]
        public string Image34 { get; set; }

        [JsonProperty(PropertyName = "image_44")]
        public string Image44 { get; set; }

        [JsonProperty(PropertyName = "image_68")]
        public string Image68 { get; set; }

        [JsonProperty(PropertyName = "image_88")]
        public string Image88 { get; set; }

        [JsonProperty(PropertyName = "image_102")]
        public string Image102 { get; set; }
        
        [JsonProperty(PropertyName = "image_132")]
        public string Image132 { get; set; }
        
        [JsonProperty(PropertyName = "image_default")]
        public bool ImageDefault { get; set; }
    }
}
