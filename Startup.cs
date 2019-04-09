using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C229_G1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace C229_G1
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
            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration["Data:SoccerSystemIdentity:ConnectionString"]));
            services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<AppIdentityDbContext>()
            .AddDefaultTokenProviders();

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

            // adds MVC to the IApplicationBuilder request execution with a default route   
            app.UseStatusCodePages();
            app.UseStaticFiles(); //marks the files in web root as servable
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
            SeedData.EnsurePoputated(app);
            IdentitySeedData.EnsurePopulated(app);

        }
    }
}
