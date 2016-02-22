using Newtonsoft.Json;

namespace SlackSharp.WebApi.Users
{
    public class SlackUser
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "team_id")]
        public string TeamId { get; set; }

        public string Name { get; set; }

        public bool Deleted { get; set; }

        public string Status { get; set; }

        public string Color { get; set; }

        [JsonProperty(PropertyName = "real_name")]
        public string RealName { get; set; }

        [JsonProperty(PropertyName = "tz")]
        public string TimeZone { get; set; }

        [JsonProperty(PropertyName = "tz_label")]
        public string TimeZoneLabel { get; set; }

        [JsonProperty(PropertyName = "tz_offset")]
        public string TimeZoneOffset { get; set; }

        public SlackUserProfile Profile { get; set; }

        [JsonProperty(PropertyName = "is_admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty(PropertyName = "is_owner")]
        public bool IsOwner { get; set; }

        [JsonProperty(PropertyName = "is_primary_owner")]
        public bool IsPrimaryOwner { get; set; }

        [JsonProperty(PropertyName = "is_restricted")]
        public bool IsRestricted { get; set; }

        [JsonProperty(PropertyName = "is_ultra_restricted")]
        public bool IsUltraRestricted { get; set; }

        [JsonProperty(PropertyName = "is_bot")]
        public bool IsBot { get; set; }

        [JsonProperty(PropertyName = "has_2fa")]
        public bool Has2fa { get; set; }

        [JsonProperty(PropertyName = "two_factor_type")]
        public string TwoFactoryTye { get; set; }

        [JsonProperty(PropertyName = "has_files")]
        public bool HasFiles { get; set; }

    }
}
