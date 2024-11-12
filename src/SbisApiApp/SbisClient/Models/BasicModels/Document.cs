#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using Newtonsoft.Json;

namespace SbisApiApp.SbisClient.Models.BasicModels
{
    public sealed record Document
    {
        [JsonProperty("Вложение")]
        public Attchement[] Attchements { get; init; }

        [JsonProperty("Дата")]
        public string Date { get; init; }

        [JsonProperty("ДатаВремяСоздания")]
        public string DateTime { get; init; }

        [JsonProperty("Идентификатор")]
        public Guid Id { get; init; }
    }
}
