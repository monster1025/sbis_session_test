using Autofac;
using Microsoft.Extensions.Configuration;
using NLog;
using SbisApiApp.App;
using SbisApiApp.SbisClient;
using ILogger = NLog.ILogger;

namespace SbisApiApp;

public class DI
{
    public void Build(ContainerBuilder builder)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();
        builder.Register(c => config).As<IConfiguration>().SingleInstance();

        builder.RegisterType<App.App>().As<IApp>();
        builder.RegisterType<SbisApi>().As<ISbisApi>();

        builder.Register(c => LogManager.GetLogger("main")).As<ILogger>();
    }
}