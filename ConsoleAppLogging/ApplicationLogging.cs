using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace ConsoleAppLogging
{
    public static class ApplicationLogging
    {
        public static ILogger CreateLogger<T>() =>
            s_loggerFactory.CreateLogger<T>();

        private static readonly ILoggerFactory s_loggerFactory = LoggerFactory.Create(AddNLog);

        private static void AddNLog(ILoggingBuilder builder)
        {
            var configJson = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            LogManager.Configuration = new NLogLoggingConfiguration(configJson.GetSection("NLog"));
            builder.AddNLog();
        }
    }
}
