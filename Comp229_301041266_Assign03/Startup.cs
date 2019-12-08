using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Comp229_301041266_Assign03.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Comp229_301041266_Assign03
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                Configuration["Data:RecipeBook:ConnectionString"]
                )
                );

            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(
                Configuration["Data:RecipeBookIdentity:ConnectionString"]));

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores
                <AppIdentityDbContext>().AddDefaultTokenProviders();

            services.AddTransient<IRecipeRepository, EFRecipeRepository>();
            services.AddTransient<IReviewRecipeRepository, EFReviewRecipeRepository>();
            services.AddTransient<IFavouriteRecipeRespository, EFFavouriteRespository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            
            app.UseStaticFiles();
            SeedRecipe.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);

        }
    }
}
