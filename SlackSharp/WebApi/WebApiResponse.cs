using Newtonsoft.Json;
using SlackSharp.WebApi.Errors;

namespace SlackSharp.WebApi
{
    public class WebApiResponse
    {
        public bool Ok { get; set; }
        
        [JsonConverter(typeof(SlackErrorJsonConverter))]
        public SlackError Error { get; set; }
        
        [JsonConverter(typeof(SlackWarningJsonConverter))]
        public SlackWarning Warning { get; set; }
    }
}
