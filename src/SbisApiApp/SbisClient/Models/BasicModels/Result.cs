#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using Newtonsoft.Json;

namespace SbisApiApp.SbisClient.Models.BasicModels
{
    public sealed record Result
    {
        [JsonProperty("Документ")]
        public Document[]? Documents { get; init; }

        [JsonProperty("Навигация")]
        public Navigation? Navigation { get; init; }

        [JsonProperty("Автор")]
        public Author? Author { get; init; }
    }
}
