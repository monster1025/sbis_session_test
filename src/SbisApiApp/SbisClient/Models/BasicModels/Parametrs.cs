#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using Newtonsoft.Json;

namespace SbisApiApp.SbisClient.Models.BasicModels
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed record Parametrs
    {
        [JsonProperty("Параметр")]
        public Parametr? Parametr { get; init; }

        [JsonProperty("Фильтр")]
        public Filter? Filter { get; init; }

        [JsonProperty("Документ")]
        public DocumentParameters? DocumentParameters { get; init; }
    }
}
