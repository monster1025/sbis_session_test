using Newtonsoft.Json;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace SbisApiApp.SbisClient.Models.BasicModels;

public sealed record DocumentParameters
{
    [JsonProperty("Идентификатор")]
    public string PackageExternalId { get; init; }
}