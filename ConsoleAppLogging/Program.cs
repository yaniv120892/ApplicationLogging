using Microsoft.Extensions.Logging;

namespace ConsoleAppLogging
{
    public class Program
    {
        private static readonly ILogger s_logger = ApplicationLogging.CreateLogger<Program>();

        static void Main()
        {
            s_logger.LogCritical("LogCritical");
            s_logger.LogDebug("LogDebug");
            s_logger.LogError("LogError");
            s_logger.LogInformation("LogInformation");
            s_logger.LogTrace("LogTrace");
            s_logger.LogWarning("LogWarning");
        }
    }
}
