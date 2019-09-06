using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PUBG.Data;
using PUBG.Helper;
using PUBG.Models;

namespace PUBG
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddHttpsRedirection(options =>
            {
                options.HttpsPort = 443;
            });
            services.AddScoped<Auth>();
            services.AddDbContext<ApplicationDbContext>(options =>
                            options.UseSqlServer(
                                Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<ApplicationUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddSession(option => {
                option.Cookie.HttpOnly = true;
                option.Cookie.IsEssential = true;
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = "2275665719412306";
                facebookOptions.AppSecret = "11a235201819575a30fa9c038300d4cb";
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

           
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
                   
               app.UseDatabaseErrorPage();
               
                
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
               
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "Control",
                  template: "{area:exists}/{controller=Login}/{action=Index}/{id?}"
                );
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
