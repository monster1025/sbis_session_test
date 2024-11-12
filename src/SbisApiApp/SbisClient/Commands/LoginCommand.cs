using NLog;
using SbisApiApp.SbisClient.Models.RequestModel;
using SbisApiApp.SbisClient.Models.ResponseModel;

namespace SbisApiApp.SbisClient.Commands
{
    public sealed class LoginCommand : Command
    {
        protected override string Route => "auth/service/";

        public LoginCommand(HttpClient httpClient, ILogger logger) : base(httpClient, logger) { }

        public async Task<string> LoginAsync(string login, string password, CancellationToken cancellationToken)
        {
            var request = new LoginRequest(login, password);
            var result = await ExecutePostAsync<ResponseLogin>(request, cancellationToken);
            return result.Result;
        }
    }
}
