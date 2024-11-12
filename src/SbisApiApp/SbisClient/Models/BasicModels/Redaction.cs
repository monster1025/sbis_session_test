using Newtonsoft.Json;
using SbisApiApp.SbisClient.Converters;

namespace SbisApiApp.SbisClient.Models.BasicModels
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed record Redaction
    {
        [JsonProperty("ДатаВремя")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateTime { get; init; }

        [JsonProperty("Номер")]
        public int Number { get; init; }
    }
}
