using SbisApiApp.SbisClient.Enums;
using SbisApiApp.SbisClient.Models;

namespace SbisApiApp.SbisClient
{
    public interface ISbisApi
    {
        Task<bool> PingAsync(string url);

        Task LoginAsync(string url, string login, string password, CancellationToken cancellationToken);

        Task<IReadOnlyCollection<SbisDocument>> GetDocumentsIdAsync(string inn, string kpp, DocumentType docType, DateTime dateFrom, CancellationToken cancellationToken);

        Task<string> GetPackageAuthorNameAsync(string externalPackageId, CancellationToken cancellationToken);

        Task<string> GetVersion(string url);
        void SetUserAgent(string userAgent);
        string ApiKey { get; set; }
    }
}
