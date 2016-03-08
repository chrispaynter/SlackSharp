using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SlackSharp.Rtm
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SlackRtmMessageType
    {
        [EnumMember(Value = "message")]
        Message,

        [EnumMember(Value = "typing")]
        Typing,

        [EnumMember(Value = "ping")]
        Ping,

        [EnumMember(Value = "pong")]
        Pong
    }
}