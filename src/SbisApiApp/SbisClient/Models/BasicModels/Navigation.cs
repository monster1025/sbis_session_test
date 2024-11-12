using Newtonsoft.Json;
using SbisApiApp.SbisClient.Converters;

namespace SbisApiApp.SbisClient.Models.BasicModels
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed record Navigation
    {
        [JsonProperty("ЕстьЕще")]
        [JsonConverter(typeof(BooleanConverter))]
        public bool? IsAnyMore { get; init; }

        [JsonProperty("РазмерСтраницы")]
        public int PageSize { get; init; }

        [JsonProperty("Страница")]
        public int Page { get; init; }
    }
}
