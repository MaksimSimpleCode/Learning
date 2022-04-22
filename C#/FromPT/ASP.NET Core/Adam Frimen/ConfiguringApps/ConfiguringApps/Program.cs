using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguringApps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateBuildWebHost(args).Run();
        }

        public static IWebHost CreateBuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                    .UseDefaultServiceProvider(options =>
                    options.ValidateScopes = false)
                    .Build();

    }
}
