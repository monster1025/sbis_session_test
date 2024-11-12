#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using Newtonsoft.Json;

namespace SbisApiApp.SbisClient.Models.BasicModels
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public abstract record RequestModelBase
    {
        [JsonProperty("params")]
        public Parametrs Parametrs { get; init; }

        [JsonProperty("id")]
        public int Id { get; init; } = 0;

        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; init; } = "2.0";

        [JsonProperty("method")]
        public abstract string Method { get; }
    }
}
