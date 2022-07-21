using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMessageSender, SmsMessageSender>();    
            services.AddTransient<IMessageSender, EmailMessageSender>();
            
            services.AddTransient<TimeService>();
            services.AddTransient<MessageService>();    //Этот сервис определяет другие сервисы выше, и вместо них его можно вписывать в аргументы Configure.
                                                        //Будет вызван последний сервис в качестве snder
                                                   

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MessageService messageSender, TimeService timeService)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                var path = context.Request.Path;
                if(path=="/date")
                {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    await context.Response.WriteAsync("Жопа");
                }
                else
                {
                    IMessageSender messageSender2 = app.ApplicationServices.GetService<IMessageSender>();


                    context.Response.ContentType = "text/html; charset=utf-8";


                    await context.Response.WriteAsync(messageSender.Send());
                    await context.Response.WriteAsync("\n" + messageSender2.Send());   //2 способ
                    await context.Response.WriteAsync($"\nТекущее время: {timeService?.GetTime()}");
                }
               
            });

        }
    }
}
