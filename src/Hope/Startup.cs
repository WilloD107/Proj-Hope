using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Hope.Driver.Linux;
using Hope.Game.Apex;
using Hope.Logging;

namespace Hope
{
    public static class Startup
    {
        #region Statics

        public static void ConfigureLogging(ILoggingBuilder builder)
        {
            builder.ClearProviders();
            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, LoggerProvider>());
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Linux>();
            Bootstrap.ConfigureServices(services);
        }

        #endregion
    }
}