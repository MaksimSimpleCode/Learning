using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguringApps.Infrastructure
{
    public class ShortCircuitMiddleware
    {
        private RequestDelegate nextDelegate;
        public ShortCircuitMiddleware(RequestDelegate next) =>
        nextDelegate = next;
        public async Task Invoke(HttpContext httpContext)
        {

            //если в заголовке User-Agent присутсвует edge, то эта middleware срабатывает иначе передает управление дальше
            //if (httpContext.Request.Headers["User-Agent"]
            //.Any(h => h.ToLower().Contains("edg")))
            //{
            //    httpContext.Response.StatusCode = 403;
            //}
            //else
            //{
            //    await nextDelegate.Invoke(httpContext);
            //}

            //Теперь благодаря middeleware BrowserTypeMiddleware мы в принципе откланяем все запросы от Edge
            if (httpContext.Items["EdgeBrowser"]as bool? == true)
            {
                httpContext.Response.StatusCode = 403;
            }
            else
            {
                await nextDelegate.Invoke(httpContext);
            }

        }
    }
}
