using System;
using Newtonsoft.Json;

namespace SlackSharp.WebApi.Errors
{
    internal class SlackErrorJsonConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException("TODO");
            // return DateTime.ParseExact(reader.Value as string, "yyyyMMddTHHmmss+1100", CultureInfo.CurrentCulture);
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException("TODO");
        }
    }
}