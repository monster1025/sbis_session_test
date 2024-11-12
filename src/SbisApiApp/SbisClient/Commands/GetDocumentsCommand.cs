using NLog;
using SbisApiApp.SbisClient.Enums;
using SbisApiApp.SbisClient.Models;
using SbisApiApp.SbisClient.Models.RequestModel;
using SbisApiApp.SbisClient.Models.ResponseModel;

#pragma warning disable CS8602 // Dereference of a possibly null reference.

namespace SbisApiApp.SbisClient.Commands
{
    public sealed class GetDocumentsCommand : Command
    {
        protected override string Route => "/service/?srv=1";

        private static readonly string[] ListForSkip =
        {
            "ПисьмоЭДО",
            "Доверенность"
        };

        private readonly ILogger _logger;
                
        public GetDocumentsCommand(HttpClient httpClient, ILogger logger) : base(httpClient, logger)
        {
            _logger = logger;
        }

        public async Task<IReadOnlyCollection<SbisDocument>> GetDocumentIdsAsync(string inn, string kpp, DocumentType docType, DateTime dateFrom, CancellationToken cancellationToken)
        {
            var documentIds = new List<SbisDocument>();
            int page = 0;
            ResponseGetDocuments result;

            do
            {
                var request = new GetDocumentsRequest(inn, kpp, docType, dateFrom, page++);
                result = await ExecutePostAsync<ResponseGetDocuments>(request, cancellationToken);

                foreach (var pack in result.Result.Documents)
                {
                    if (pack.Attchements is not null)
                    {
                        var forSkip = pack.Attchements.Where(y => ListForSkip.Contains(y.Type));
                        _logger.Info($"Пропускаю: {string.Join(", ", forSkip.Select(x => x.Id.ToString()))}");
                        var needToAdd = pack.Attchements.Where(y => !ListForSkip.Contains(y.Type));
                        documentIds.AddRange(needToAdd.Select(x =>
                        new SbisDocument()
                        {
                            ExternalId = x.Id,
                            PackageExternalId = pack.Id,
                            SendTimestamp = x.Redaction.DateTime
                        }));
                    }
                }
            }
            while (result.Result.Navigation.IsAnyMore!.Value);

            return documentIds;
        }
    }
}
