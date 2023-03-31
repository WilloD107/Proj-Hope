using Microsoft.Extensions.DependencyInjection;
using Hope.Game.Apex.Core.Interfaces;

namespace Hope.Game.Apex.Feature.Sense
{
    public static class Bootstrap
    {
        #region Statics

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Config>();
            services.AddTransient<IFeature, Feature>();
        }

        #endregion
    }
}