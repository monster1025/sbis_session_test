using Autofac;
using SbisApiApp.App;

namespace SbisApiApp;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var builder = new ContainerBuilder();
        new DI().Build(builder);
        var container = builder.Build();

        var app = container.Resolve<IApp>();
        await app.RunAsync(args);
    }
}