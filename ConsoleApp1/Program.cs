using CleanLog;
using ConsoleApp;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    public static async Task Main(string[] args)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);

        var serviceProvider = services.BuildServiceProvider();

        await serviceProvider.GetService<App>()!.Run(args);
    }


    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddLogging(builder =>
        {
            builder.AddCleanConsole();
        });

        services.AddTransient<App>();
    }
}
