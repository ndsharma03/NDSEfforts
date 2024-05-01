using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity2010.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Identity2010.Infrastructure;
namespace Identity2010
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
            services.AddDbContext<AppDBContext>(options => {
                                        options.UseSqlServer(Configuration["ConnectionStrings:IdentityDBConnection"]);
            }) ;
            // ******* Adding Custom PAssword Validator *****************
            services.AddTransient<IPasswordValidator<AppUser>, CustomPasswordValidator>();

            // ******* Adding Custom User Validator *****************
            services.AddTransient<IUserValidator<AppUser>,CustomUserValidator>();
            
            services.AddIdentity<AppUser, IdentityRole>(

            //********** Optional configuration for password policy*************
            //opts =>
            //{
            //   ----------user policy setting-----------------
            //     opts.User.RequireUniqueEmail = true;
            //     opts.User.AllowedUserNameCharacters = "abcdefghinjlmnopqrs";

            ////  -----------Password policy setting------------
            //    opts.Password.RequiredLength = 6;
            //    opts.Password.RequireNonAlphanumeric = false;
            //    opts.Password.RequireLowercase = false;
            //    opts.Password.RequireUppercase = false;
            //    opts.Password.RequireDigit = false;
            //}
                )
                .AddEntityFrameworkStores<AppDBContext>()
                .AddDefaultTokenProviders();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.Use(async (context, next) =>
            {
                System.Diagnostics.Debug.WriteLine("######################");
                await next.Invoke();
            }) ;
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
