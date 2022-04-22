using LanguageFeatuers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatuers.Controllers
{
    public class HomeController:Controller
    {
        public async Task<ViewResult> Index()  
        {
            //List<string> results = new List<string>();
            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name??"<No Name>";
            //    decimal? price = p?.Price??0;
            //    results.Add(string.Format("Name: {0}, Price: {1}", name, price));
            //}
            // return View(results);

            //Используем анонимный тип
            var products = new[] {
            new { Name = "Kayak" , Price = 275M } ,
            new { Name = "Lifejacket", Price = 48.95M },
            new { Name = "Soccer ball", Price = 19.50M },
            new { Name = "Corner flag", Price = 34.95M }
            };

            //return View(products.Select(p => p.Name));
            //Как я полня более надежная версия формирования строки
            //Как я понял у нас тут конфликт с p.Name/Price так как он может быть и объектом и свойством, а nameof позволяет решить эту проблему
            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof (p.Price)}: {p.Price}"));


            //используем асинхронный метод
            //long? length = await MyAsyncMethods.GetPagelengthAsync();
            //return View(new string[] { $"Length: { length }"});

        }
    }
}
