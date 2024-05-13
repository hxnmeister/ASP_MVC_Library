using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Library
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();

            app.UseMvc((route) =>
            {
                route.MapRoute("default", "/", new { controller = "Library", action = "Index" });
                route.MapRoute("searching", "/searching-results", new { controller = "Library", action = "SearchingResults" });
                route.MapRoute("createBook", "/add-book", new { controller = "Library", action = "CreateBook" });
                route.MapRoute("addingBook", "/adding-book", new { controller = "Library", action = "AddingBook" });
            });
        }
    }
}
