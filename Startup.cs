using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mariia_S_301052981.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mariia_S_301052981
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:SoccerSystem:ConnectionString"]));
            services.AddTransient<IClubRepository, EFClubRepository>();
            services.AddTransient<IPlayerRepository, EFPlayerRepository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute(); // adds MVC to the IApplicationBuilder request execution with a default route 
            app.UseStaticFiles(); //marks the files in web root as servable  
            app.UseStatusCodePages();
            SeedData.EnsurePoputated(app);
        }
    }
}
