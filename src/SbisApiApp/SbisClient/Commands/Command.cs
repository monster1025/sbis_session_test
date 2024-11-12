using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using SbisApiApp.SbisClient.Models.BasicModels;

namespace SbisApiApp.SbisClient.Commands
{
    public abstract class Command
    {
        protected abstract string Route { get; }

        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;

        protected Command(HttpClient httpClient, ILogger logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        protected async Task<TResponse> ExecutePostAsync<TResponse>(RequestModelBase request, CancellationToken cancellationToken) where TResponse : ResponseModelBase
        {
            var requestJson = JsonConvert.SerializeObject(request);
            var data = new StringContent(requestJson, Encoding.UTF8, "application/json");

            _logger.Trace($"Отправляю запрос в СБИС: {requestJson}");
            
            var response = await _httpClient.PostAsync(Route, data, cancellationToken);
            
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync(cancellationToken);

                JToken jobject = JObject.Parse(json);
                var result = jobject.ToObject<TResponse>();
                _logger.Trace($"Получен ответ из СБИС: {json}");
                return result!;
            }

            throw new HttpRequestException($"Bad request {response}");
        }
    }
}
