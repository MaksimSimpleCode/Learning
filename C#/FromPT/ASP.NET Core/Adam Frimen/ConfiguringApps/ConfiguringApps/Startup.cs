using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ConfiguringApps.Infrastructure;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;


namespace ConfiguringApps
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<UptimeService>();
            services.AddMvc(options => options.EnableEndpointRouting = false).AddMvcOptions(options=>options.RespectBrowserAcceptHeader=true);
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if ((Configuration.GetSection("ShortCircuitMiddelware")?.GetValue<bool>("EnableBrowserShortCircuit")).Value)
            {
                app.UseMiddleware<BrowserTypeMiddleware>(); 
                app.UseMiddleware<ShortCircuitMiddleware>();  
            }
            if (env.IsDevelopment())
            {
                //app.UseMiddleware<ErrorMiddleware>(); //Уточняем ошибки
                //app.UseMiddleware<BrowserTypeMiddleware>(); //определяем браузер
                //app.UseMiddleware<ShortCircuitMiddleware>(); //отказываем в доступе браузеру Edge    
                //app.UseMiddleware<ContentMiddeleware>();

                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
