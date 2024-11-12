using NLog;
using SbisApiApp.SbisClient.Commands;
using SbisApiApp.SbisClient.Enums;
using SbisApiApp.SbisClient.Models;

namespace SbisApiApp.SbisClient
{
    public sealed class SbisApi : ISbisApi
    {
        private const string AuthHeaderToken = "X-SBISSessionID";
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        public string ApiKey { get; set; }

        public SbisApi( ILogger logger)
        {
            _httpClient = new HttpClient();
            _logger = logger;
        }

        public void SetUserAgent(string userAgent)
        {
            _httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
        }

        public async Task<string> GetVersion(string url)
        {
            var result = await new GetVersionCommand(_httpClient, _logger).GetVersion(CancellationToken.None);
            return result;
        }

        public async Task<bool> PingAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);
            return response.IsSuccessStatusCode;
        }

        public async Task LoginAsync(string url,
                                     string login,
                                     string password,
                                     CancellationToken cancellationToken)
        {
            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri(url);
            }

            var apikey = await new LoginCommand(_httpClient, _logger).LoginAsync(login, password, cancellationToken);
            ApiKey = apikey;
            SetAuthHeader(apikey);
        }

        public async Task<IReadOnlyCollection<SbisDocument>> GetDocumentsIdAsync(string inn,
                                                                                 string kpp,
                                                                                 DocumentType docType,
                                                                                 DateTime dateFrom,
                                                                                 CancellationToken cancellationToken)
        {
            var result = await new GetDocumentsCommand(_httpClient, _logger).GetDocumentIdsAsync(inn, kpp, docType, dateFrom, cancellationToken);
            return result;
        }

        public async Task<string> GetPackageAuthorNameAsync(string externalPackageId, CancellationToken cancellationToken)
        {
            var result = await new GetPackageAuthorCommand(_httpClient, _logger).GetPackageAuthorAsync(externalPackageId, cancellationToken);

            return result;
        }

        private void SetAuthHeader(string apikey)
        {
            if (_httpClient.DefaultRequestHeaders.Contains(AuthHeaderToken))
            {
                _httpClient.DefaultRequestHeaders.Remove(AuthHeaderToken);
            }

            _httpClient.DefaultRequestHeaders.Add(AuthHeaderToken, apikey);
        }
    }
}
