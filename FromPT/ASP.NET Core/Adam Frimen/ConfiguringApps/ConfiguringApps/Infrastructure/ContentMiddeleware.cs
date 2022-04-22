using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ConfiguringApps.Infrastructure
{
    public class ContentMiddeleware
    {
        public RequestDelegate nextDelegate;
        private UptimeService uptime;
        public ContentMiddeleware(RequestDelegate next, UptimeService up)
        {
            nextDelegate = next;
            uptime = up;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path.ToString().ToLower() == "/middleware")
            {
                await httpContext.Response.WriteAsync("This is from content middleware"+
                   $"(uptime: {uptime.Uptime}ms)", Encoding.UTF8);
            }
            else
            {
                await nextDelegate.Invoke(httpContext);
            }
        }
    }
}
