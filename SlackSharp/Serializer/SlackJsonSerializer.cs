using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SlackSharp.Serializer
{
    public class SlackJsonSerializer
    {
        public static string SerializeObject(object o)
        {
            return JsonConvert.SerializeObject(o, Formatting.Indented, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }
    }
}
