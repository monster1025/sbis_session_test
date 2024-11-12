namespace SbisApiApp.SbisClient.Models
{
    public sealed record SbisDocument
    {
        public Guid ExternalId { get; init; }
        public Guid PackageExternalId { get; init; }
        public DateTime SendTimestamp { get; init; }
    }
}
