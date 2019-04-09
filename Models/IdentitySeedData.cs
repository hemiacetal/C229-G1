using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C229_G1.Models
{
    public class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";
        private const string adminRole = "Admin";


        private const string generalUser = "General";
        private const string generalPassword = "Secret123$";
        private const string generalRole = "General";

        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            UserManager<IdentityUser> userManager =
                app.ApplicationServices.GetRequiredService<UserManager<IdentityUser>>();

            RoleManager<IdentityRole> roleManager =
                app.ApplicationServices.GetRequiredService<RoleManager<IdentityRole>>();

            if (await userManager.FindByNameAsync(adminUser) == null)
            {
                if (await roleManager.FindByNameAsync(adminRole) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(adminRole));
                    await roleManager.CreateAsync(new IdentityRole(generalRole));
                }

                IdentityUser user = new IdentityUser("Admin");
                IdentityResult result = await userManager.CreateAsync(user, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, adminRole);
                }

                user = new IdentityUser("General");
                result = await userManager.CreateAsync(user, generalPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, generalRole);
                }

            }
        }
    }
}
