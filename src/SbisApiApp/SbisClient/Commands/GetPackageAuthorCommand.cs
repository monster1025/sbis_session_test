using NLog;
using SbisApiApp.SbisClient.Models.RequestModel;
using SbisApiApp.SbisClient.Models.ResponseModel;

namespace SbisApiApp.SbisClient.Commands;

public sealed class GetPackageAuthorCommand : Command
{
    protected override string Route => "/service/?srv=1";

    public GetPackageAuthorCommand(HttpClient httpClient, ILogger logger) : base(httpClient, logger) { }

    public async Task<string> GetPackageAuthorAsync(string externalPackageId, CancellationToken cancellationToken)
    {
        var request = new GetPackageAuthorRequest(externalPackageId);

        var response = await ExecutePostAsync<ResponseGetPackageAuthor>(request, cancellationToken);

        return response.Result.Author?.FirstName ?? string.Empty;
    }
}