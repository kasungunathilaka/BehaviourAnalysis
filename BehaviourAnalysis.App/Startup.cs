using System;
using System.IO;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

using BehaviourAnalysis.Domain.Interfaces;
using BehaviourAnalysis.Persistence;
using BehaviourAnalysis.Persistence.Repositories;
using BehaviourAnalysis.Services.Interfaces;
using BehaviourAnalysis.Services.Services;

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
            builder.Services.AddScoped<IQuestionService, QuestionService>();

            // Repositories   
            builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
        }

        private static void Configure(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
        }
    }
}
