using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using GoPro.NET.Repositories.GoPro.Hero;
using GoPro.NET.Repositories.GoPro.Hero10;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace GoPro.NET
{
    public class Bootstrap
    {
        public static IServiceProvider Configure()
        {
            var services = new ServiceCollection();


            // add your classes to the `services` container
            services.AddSingleton<IHero, Hero10>();

            return services.BuildServiceProvider();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    var httpClient = new HttpClient()
                    {
                        BaseAddress = new Uri("http://10.5.5.9")
                    };

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    services.AddTransient<Program>();
                    services.AddTransient(c => httpClient) ;
                    services.AddTransient(c => new Hero10(c.GetService<HttpClient>()));
                });
        }

        //public static void Initialize()
        //{
        //    //setup our DI
        //    var serviceProvider = new ServiceCollection()
        //        .AddLogging()
        //        .AddSingleton<IHero, Hero10>()
        //        .BuildServiceProvider();

        //    //configure console logging
        //    serviceProvider
        //        .GetService<ILoggerFactory>()
        //        .AddConsole();

        //    var logger = serviceProvider.GetService<ILoggerFactory>()
        //        .CreateLogger<Program>();
        //    logger.LogDebug("Starting application");

        //    //do the actual work here
        //    var bar = serviceProvider.GetService<IBarService>();
        //    bar.DoSomeRealWork();

        //    logger.LogDebug("All done!");
        //}
    }
}
