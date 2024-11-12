#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using Newtonsoft.Json;

namespace SbisApiApp.SbisClient.Models.BasicModels
{
    public sealed record Attchement
    {
        [JsonProperty("ВерсияФормата")]
        public string FormatVersion { get; set; }

        [JsonProperty("Дата")]
        public string DateTime { get; init; }

        [JsonProperty("Зашифрован")]
        public string IsEncrypted { get; set; }

        [JsonProperty("Идентификатор")]
        public Guid Id { get; init; }

        [JsonProperty("Редакция")]
        public Redaction Redaction { get; init; }
        
        [JsonProperty("Тип")]
        public string Type { get; init; }
    }
}
