using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController:Controller
    {
        private readonly IAllCars _carRep;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.GetFavCars
            };
            return View(homeCars);
        }
    }

}
