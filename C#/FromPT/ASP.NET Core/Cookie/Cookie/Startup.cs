using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookie
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async (context) =>
            {
                //читаем куки, если нету до добавляем
                
                if (context.Request.Cookies.ContainsKey("name"))
                {
                    string? name = context.Request.Cookies["name"];
                    await context.Response.WriteAsync($"Hello {name}!");
                }
                else
                {
                    context.Response.Cookies.Append("name", "Tom");
                    await context.Response.WriteAsync("Hello World!");
                }
            });
        }
    }
}
