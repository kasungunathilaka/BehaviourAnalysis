using System;
using System.IO;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using BehaviourAnalysis.Persistence;

[assembly: FunctionsStartup(typeof(BehaviourAnalysis.App.Startup))]
namespace BehaviourAnalysis.App
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(
                    Environment.GetEnvironmentVariable("ConnectionStrings:Default"),
                    opt => opt.EnableRetryOnFailure());
            }, ServiceLifetime.Transient);

            var configBuilder = new ConfigurationBuilder();
            Configure(configBuilder);

            // Azure Function Services
        }

        private static void Configure(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
        }
    }
}
