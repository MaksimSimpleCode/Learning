using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlsAndRoutes.Models;

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController:Controller
    {
        public ViewResult Index() => View("Result",
            new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(Index)
            });
        public ViewResult List() => View("Result",
            new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(List)
            });

    }
}
