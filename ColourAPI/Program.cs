// YouTube - Les Jackkson ( https://www.bing.com/videos/search?q=YouTube+Docker+Les+Jackson&docid=608051658643275851&mid=84EDE02B090A90169A3084EDE02B090A90169A30&view=detail&FORM=VIRE)
// Docker Compose with .NET Core & SQL Server (Step-by-Step)
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ColourAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
