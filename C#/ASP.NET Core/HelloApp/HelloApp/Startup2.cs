using HelloApp.middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp
{
    public class Startup2
    {
        public void Configure(IApplicationBuilder app)
        {
            //index?token=
            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseMiddleware<AuthenticationMiddleware>();
            app.UseMiddleware<RoutingMiddleware>();
        }
    }
}
