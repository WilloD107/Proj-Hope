using Microsoft.Extensions.Hosting;
using Hope;

await Host.CreateDefaultBuilder(args)
    .UseSystemd()
    .ConfigureLogging(Startup.ConfigureLogging)
    .ConfigureServices(Startup.ConfigureServices)
    .RunConsoleAsync().ConfigureAwait(false);