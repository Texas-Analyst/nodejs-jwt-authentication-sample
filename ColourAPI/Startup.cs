using ColourAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace ColourAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);


            // https://www.npgsql.org/efcore/index.html
            services.AddDbContext<ColourContext>((options) =>
            { 
                options.UseNpgsql(Configuration["Postgres:connectionString"]);                
            });

            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0#middleware-order

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            if (!env.IsDevelopment())
            {
                // Use Http Strict Transport Security protocol
                app.UseHsts();
            }


            // Redirects all requests HTTP -->> HTTPS

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

          //  PrepDb.PrepPopulation(app);

            // ALWAYS terminates the request pipelone, so typically is the last entry in this method
            app.Run(async context =>
            {
                await context.Response.WriteAsync("ColourAPI successfully configured.");
            });

        }
    }
}
