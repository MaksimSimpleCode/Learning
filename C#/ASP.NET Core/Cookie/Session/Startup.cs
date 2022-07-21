using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Session
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                //options.Cookie.Name = ".MyApp.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(5);  // ������ ����� ��������� ������
               // options.Cookie.IsEssential = true;
            });
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();   // ��������� �������� ������ � ��������
            app.Run(async (context) =>
            {
                //���� ���� ������ �� �����������, ���� ��� �� ���������
                if (context.Session.Keys.Contains("person"))
                {
                    Person person = context.Session.Get<Person>("person");
                    await context.Response.WriteAsync($"Hello {person.Name}, your age: {person.Age}!");
                }
                else
                {
                    Person person = new Person { Name = "Tom", Age = 22 };
                    context.Session.Set<Person>("person", person);
                    await context.Response.WriteAsync("Hello World!");
                }
            });
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public static class SessionExtensions
    {   //��������� ��������� ������ ��� ������ � �������������/���������������
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize<T>(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonSerializer.Deserialize<T>(value);
        }
    }
}
