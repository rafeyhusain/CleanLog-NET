using Microsoft.Extensions.Logging;

namespace ConsoleApp
{
    public class App
    {
        private readonly ILogger<App> _logger; 

        public App(ILogger<App> logger)
        {
            _logger = logger;
        }

        public async Task Run(string[] args)
        {
            _logger.LogInformation("This is a sample Information log...");
            _logger.LogDebug("This is a sample Debug log...");
            _logger.LogTrace("This is a sample Trace log...");
            _logger.LogError("This is a sample Error log...");
            _logger.LogWarning("This is a sample Warning log...");
            _logger.LogCritical("This is a sample Critical log...");

            await Task.WhenAll();
        }
   }
}