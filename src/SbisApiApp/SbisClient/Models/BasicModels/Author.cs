using Newtonsoft.Json;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace SbisApiApp.SbisClient.Models.BasicModels;

public sealed record Author
{
    [JsonProperty("Идентификатор")]
    public string Id { get; init; }
    
    [JsonProperty("Имя")]
    public string FirstName { get; init; }
    
    [JsonProperty("Отчество")]
    public string Patronymic { get; init; }
    
    [JsonProperty("Фамилия")]
    public string LastName { get; init; }
}