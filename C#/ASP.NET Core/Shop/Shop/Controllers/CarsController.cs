using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController:Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)        //http....Cars/List
        {
            string _category = category;
            IEnumerable<Car> cars= null;
            string currentCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Электромобили")).OrderBy(i => i.Id);
                    currentCategory = "Электромобили";
                }
                else
                {
                    if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                    {
                        cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Классические автомобили")).OrderBy(i => i.Id);
                        currentCategory = "Классические автомобили";
                    }
                }
              
            }
           

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currentCategory
            };

            ViewBag.Title = "Страница с автомобилями";
           
            return View(carObj);  //Как то связан с папкой View и папкой Car, судя по всему связь контроллера с вьюшкой
        }
    }
}
