using System;
using Newtonsoft.Json;

namespace SlackSharp.WebApi.InstantMessage
{
    public class SlackInstantMessage
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "is_im")]
        public bool IsIm { get; set; }

        public string User { get; set; }

        public string Created { get; set; }
        
        [JsonProperty(PropertyName = "is_user_deleted")]
        public bool IsUserDeleted { get; set; }
    }
}
