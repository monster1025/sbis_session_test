using SbisApiApp.SbisClient;
using ILogger = NLog.ILogger;

namespace SbisApiApp.App;

internal class App: IApp
{
    private readonly Func<ISbisApi> _sbisApiFactory;
    private readonly ILogger _logger;
    private readonly string _username = "КутергинПавелСергеевич";
    private readonly string _password = "***";

    public App(
        Func<ISbisApi> sbisApiFactory,
        ILogger logger)
    {
        _sbisApiFactory = sbisApiFactory;
        _logger = logger;
    }

    public async Task RunAsync(string[] args)
    {
        var url = "https://fix-online.sbis.ru";

        await Parallel.ForAsync(0, 30, new ParallelOptions() { MaxDegreeOfParallelism = 100}, async (i, token) =>
        {
            var client = _sbisApiFactory();
            client.SetUserAgent($"sbis-api-sample-app-{Random.Shared.Next(0, 100000)}");
            await client.LoginAsync(url, _username, _password, CancellationToken.None);
            while (true)
            {
                var result = await client.GetVersion(url);
                _logger.Info($"[{client.ApiKey}] {result}");
                await Task.Delay(TimeSpan.FromSeconds(5), token);
            }
        });
    }
}