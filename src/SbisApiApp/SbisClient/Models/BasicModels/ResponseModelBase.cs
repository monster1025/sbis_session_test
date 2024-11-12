#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace SbisApiApp.SbisClient.Models.BasicModels
{
    public abstract record ResponseModelBase
    {
        public string Jsonrpc { get; init; }
        public int Id { get; init; }
    }
}
