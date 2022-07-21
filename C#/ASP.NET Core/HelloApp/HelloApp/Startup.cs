using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HelloApp
{
    public class Startup
    {
        IWebHostEnvironment _env;
        public Startup(IWebHostEnvironment env)
        {
            _env = env;
        }
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // ���� ���������� � �������� ����������
            if (env.IsDevelopment())
            {
                // �� ������� ���������� �� ������, ��� ������� ������
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //���� �� � �������� ���������� � �������� ������ �� �������������� �� �������� error
                app.UseExceptionHandler("/error");
            }

            // ��������� ����������� �������������
            app.UseRouting();

            //��� ������ ���������, ����� ��������� 2 ������ TokenExtensions � TokenMiddleware
            //app.UseToken("555");
            app.Map("/error", ap => ap.Run(async context =>
            {
                await context.Response.WriteAsync("DivideByZeroException occured!");
            }));

            //������������� ������, ������� ����� ��������������
            app.UseEndpoints(endpoints =>
            {
                // ��������� ������� - �������� ��������� ������� � ���� ������� context
                endpoints.MapGet("/", async context =>
                {
                    // �������� ������ � ���� ������ "Hello World!"
                    await context.Response.WriteAsync($"Hello World!\nApplication Name: {_env.ApplicationName}\nApplication Path: {_env.ContentRootPath}");
                });
                
 
                endpoints.MapGet("/test", async context =>
                {
                    
                    await context.Response.WriteAsync($"TEEEEEEEESSSSTTTTT");
                });

                
                endpoints.MapGet("/test2", async context =>
                {
                    int x = 2;
                    for (int i = 0;i<10;i++)
                    {
                        await context.Response.WriteAsync($"REZULTAAAT: {x+i}\n");
                      //Thread.Sleep(500); // ���������� �� ��� ����� ������ ������ ��� �����
                    }
                    
                });
                //������ Map ����� ���� ���������: 
                app.Map("/home", home =>
                {
                    home.Map("/index", Index);
                    home.Map("/about", About);
                });

                //app.Map("/index", Index);
                //app.Map("/about", About);

                app.Map("/testUse", TestUse);

                //?id=5
                app.MapWhen(context => {

                    return context.Request.Query.ContainsKey("id") &&
                            context.Request.Query["id"] == "5";
                }, HandleId);
            });



        }
        private static void HandleId(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("id is equal to 5");
            });
        }
        private static void TestUse(IApplicationBuilder app)
        {
            int x = 2;
            app.Use(async (context, next) =>
            {
                x = x * 2;      // 2 * 2 = 4
                await next.Invoke();    // ����� app.Run
                x = x * 2;      // 8 * 2 = 16
                await context.Response.WriteAsync($"Result: {x}");
            });

            app.Run(async (context) =>
            {
                x = x * 2;  //  4 * 2 = 8
                await Task.FromResult(0);
            });
        }
        private static void Index(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Index");
            });
        }
        private static void About(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("About");
            });
        }
    }
}
