using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SportsOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SportsOnline
{
    public class Startup
    {
        IConfiguration configuration;
        public Startup(IConfiguration config)
        {
            configuration = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //services.AddTransient<IProductRepository, FakeProductRepository>();
            services.AddDbContext<ApplicationDBContext>(options =>  options.UseSqlServer(configuration["ConnectionString"],op=>op.UseRowNumberForPaging()));
            services.AddTransient<IProductRepository, EFProductRepository>();
            ///services.AddTransient<IMyClass, MyClass>(); // just to checkhow to use custom class in controller/View.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(route =>
            {
                route.MapRoute("Default", "/{Controller=Product}/{Action=List}/{id?}");
            });
            SeedData.EnsurePopulated(app); // Propulating database with default products, if no any product exists.
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Jai Shri Ganesh!");
            });
        }
    }
}
