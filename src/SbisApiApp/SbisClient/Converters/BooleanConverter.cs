using Newtonsoft.Json;

namespace SbisApiApp.SbisClient.Converters
{
    public sealed class BooleanConverter : JsonConverter
    {
        private const string Yes = "да";
        private const string No = "нет";

        public override bool CanWrite { get { return false; } }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            var value = reader.Value;

            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return null;
            }

            if (string.Equals(Yes, value.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (string.Equals(No, value.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(string) || objectType == typeof(bool))
            {
                return true;
            }

            return false;
        }
    }
}
