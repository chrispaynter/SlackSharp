using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SlackSharp.WebApi.Errors
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SlackWarning
    {
        NoWarnings,
        ///<summary>The method was called via a POST request, and recommended practice for the specified Content-Type is to include a charset parameter. However, no charset was present. Specifically, non-form-data content types (e.g. text/plain) are the ones for which charset is recommended.</summary>
        [EnumMember(Value = "missing_charset")]
        MissingCharset,

        ///<summary>The method was called via a POST request, and the specified Content-Type is not defined to understand the charset parameter. However, charset was in fact present. Specifically, form-data content types (e.g. multipart/form-data) are the ones for which charset is superfluous.</summary>
        [EnumMember(Value = "superfluous_charset")]
        SuperfluousCharset,
    }
}