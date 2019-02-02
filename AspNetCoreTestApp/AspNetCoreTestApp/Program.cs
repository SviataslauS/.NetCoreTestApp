using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AspNetCoreTestApp.Models;
using System;
using Microsoft.EntityFrameworkCore;
using AspNetCoreTestApp.Database.Models;
using AspNetCoreTestApp.Database;

namespace AspNetCoreTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            
            //using (var scope = host.Services.CreateScope())
            //{
                var services = host.Services;

                try
                {
                    var context = services.
                        GetRequiredService<DatabaseContext>();
                    context.Database.Migrate();
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            //}

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
