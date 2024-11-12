#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SbisApiApp.SbisClient.Converters;
using SbisApiApp.SbisClient.Enums;

namespace SbisApiApp.SbisClient.Models.BasicModels
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed record Filter
    {
        [JsonProperty("ДатаВремяС")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DateTimeFrom { get; init; }

        [JsonProperty("ДатаС")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? DateFrom { get; init; }

        [JsonProperty("НашаОрганизация")]
        public OurOrganization OurOrganization { get; init; }

        [JsonProperty("Тип")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DocumentType DocumentType { get; init; }

        [JsonProperty("Навигация")]
        public Navigation Navigation { get; init; }
    }
}
