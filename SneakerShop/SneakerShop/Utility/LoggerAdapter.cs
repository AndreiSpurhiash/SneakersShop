using Serilog;
using SneakersShop.ApplicationCore.Interfaces;

namespace SneakersShop.Web.Utility
{
    public sealed class LoggerAdapter<T> : IAppLogger<T>
    {
        private readonly ILogger<T> _logger;

        public LoggerAdapter(ILoggerFactory loggerFactory, IConfiguration configuration)
        {
            var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .Enrich.FromLogContext()
            .CreateLogger();

            _logger = loggerFactory.AddSerilog(logger).CreateLogger<T>();
        }

        public void LogError(Exception exception, string? message, params object[] args) => _logger.LogError(exception, message, args);

        public void LogError(string? message, params object[] args) => _logger.LogError(message, args);

        public void LogInformation(string message, params object[] args) => _logger.LogInformation(message, args);

        public void LogWarning(string message, params object[] args) => _logger.LogWarning(message, args);
    }
}
