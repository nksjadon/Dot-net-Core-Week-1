using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tata_Power_App.Models;

namespace Tata_Power_App
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<IStoreRepository, ProductInMemoryRepository>();
            services.AddScoped<IRandomService, RandomService>();
            services.AddScoped<IBankService, BankService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            /*app.UseStaticFiles();
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("First one middleware");
                await next.Invoke();
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Second middleware");
                await next.Invoke();
            });*/

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                /*endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });*/
                 endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
