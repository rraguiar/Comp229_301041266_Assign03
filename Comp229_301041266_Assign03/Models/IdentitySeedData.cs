using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Comp229_301041266_Assign03.Models
{
    public static class IdentitySeedData
    {
        //both users will be type general. The Admin user will be type Admin on future releases
        private const string generalUser1 = "Admin";
        private const string generalPassword1 = "Password!23";
        private const string generalUser2 = "Cooker";
        private const string generalPassword2 = "Password!23";


        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            AppIdentityDbContext identityContext = app.ApplicationServices.GetRequiredService<AppIdentityDbContext>();

            identityContext.Database.Migrate();

            UserManager<IdentityUser> userManager = app.ApplicationServices.GetRequiredService<UserManager<IdentityUser>>();
            //creating the seed data for user 1 -> Admin in this case
            IdentityUser user = await userManager.FindByIdAsync(generalUser1);
            if (user == null)
            {
                user = new IdentityUser("Admin");
                await userManager.CreateAsync(user, generalPassword1);
            }
            //creating the seed data for user 2 -> cooker in this case
            user = await userManager.FindByIdAsync(generalUser2);
            if (user == null)
            {
                user = new IdentityUser("Cooker");
                await userManager.CreateAsync(user, generalPassword2);
            }
        }
    }
}
