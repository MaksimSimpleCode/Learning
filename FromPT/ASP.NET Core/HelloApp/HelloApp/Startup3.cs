using HelloApp.middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace HelloApp
{
    public class Startup3
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseDirectoryBrowser();  //позволяет пользователям просматривать содержимое каталогов на сайте
            app.UseStaticFiles();//Добовляем поддердку статических файлов

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World");
            });
        }


    }
}
