using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace SlackSharp.Extensions
{
    public static class SlackApiExtensions
    {
        public static Dictionary<string, string> ToPropertyValueDictionary(this object request)
        {
            var type = request.GetType();
            var properties = type.GetProperties();

            return properties.ToDictionary(e =>
            {
                return e.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ?? e.Name.ToLower();
            }, e => e.GetValue(request, null)?.ToString());
        }
    }
}
