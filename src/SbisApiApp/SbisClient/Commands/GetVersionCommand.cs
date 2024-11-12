using NLog;
using SbisApiApp.SbisClient.Models.RequestModel;
using SbisApiApp.SbisClient.Models.ResponseModel;

namespace SbisApiApp.SbisClient.Commands;

public class GetVersionCommand : Command
{
    protected override string Route => "/service/?srv=1";

    public GetVersionCommand(HttpClient httpClient, ILogger logger) : base(httpClient, logger)
    {

    }

    public async Task<string> GetVersion(CancellationToken cancellationToken)
    {
        var request = new GetVersionRequest();

        var response = await ExecutePostAsync<ResponseGetVersion>(request, cancellationToken);

        return response.Jsonrpc ?? string.Empty;

    }
}