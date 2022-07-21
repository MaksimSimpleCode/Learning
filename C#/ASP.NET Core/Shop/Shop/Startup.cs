using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop.Data;
using Shop.Data.Interfaces;
using Shop.Data.Mocks;
using Shop.Data.Models;
using Shop.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public class Startup
    {
        private IConfigurationRoot _configStr;
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv) 
        {
            _configStr = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_configStr.GetConnectionString("DefaultConnection")));

            //���������� ������ �� ���-�������
            //services.AddTransient<IAllCars, MockCars>();
            //services.AddTransient<ICarsCategory, MockCategory>();
            
            //���������� ������ �� ��
            services.AddTransient<IAllCars, CarRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));

            //options ��������� �������� �� ����� � ����� ������ ��� ��� ���� ��������� �� ��������, ������ ������ ������ � ������ https://stackoverflow.com/questions/57684093/using-usemvc-to-configure-mvc-is-not-supported-while-using-endpoint-routing
            services.AddMvc(options => options.EnableEndpointRouting =false);

            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();   //�������� ���������� ���� ���������
            app.UseStaticFiles();   //������ ���������� ������ css � ��
            app.UseSession();
           // app.UseMvcWithDefaultRoute();   //������ ����������� URL � �������� ���������� �� ���������
           app.UseMvc(routes =>
           {
               routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
               routes.MapRoute(name: "categoryFilter", template: "Car/{action}/{category?}", defaults: new { Controller = "Car", action = "List" });
           });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDbContext db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                DBObjects.Initial(db);
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
