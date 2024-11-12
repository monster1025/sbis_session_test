#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using Newtonsoft.Json;

namespace SbisApiApp.SbisClient.Models.BasicModels
{
    public sealed record LegalEntity
    {
        [JsonProperty("ИНН")]
        public string Inn { get; init; }

        [JsonProperty("КПП")]
        public string Kpp { get; init; }
    }
}
