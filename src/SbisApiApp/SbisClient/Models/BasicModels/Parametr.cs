#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using Newtonsoft.Json;

namespace SbisApiApp.SbisClient.Models.BasicModels
{
    public sealed record Parametr
    {
        [JsonProperty("Логин")]
        public string Login { get; init; }
        [JsonProperty("Пароль")]
        public string Password { get; init; }
    }
}
