using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using netcoreapp3_template.Models;

namespace netcoreapp3_template
{
    public class Startup
    {
        public Startup(IConfiguration config) {
            Configuration = config;
        }

        private IConfiguration Configuration {get; set;}
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<netcoreapp3Context>(opts => {
                opts.UseSqlServer(Configuration["ConnectionStrings:netcoreapp3Connection"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                 endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
