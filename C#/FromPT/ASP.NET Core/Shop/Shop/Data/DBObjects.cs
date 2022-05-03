using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDbContext db)
        {
           
            if(!db.Category.Any())
            {
                db.Category.AddRange(Categories.Select(c=>c.Value));
            }

            if (!db.Car.Any())
            {
                db.AddRange(
                        new Car
                        {
                            Name = "Tesla",
                            ShortDesc = "",
                            Img = "/img/Cat_clon.jpg",
                            Price = 45000,
                            IsFavourite = true,
                            Available = true,
                            Category = Categories["Электромобили"]
                        },
                    new Car
                    {
                        Name = "Mercedes C Class",
                        ShortDesc = "Уютный и большой",
                        LongtDesc = "Удобный автомобиль для города",
                        Img = "",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongtDesc = "Удобный автомобиль для города",
                        Img = "",
                        Price = 60000,
                        IsFavourite = false,
                        Available = false,
                        Category = Categories["Классические автомобили"]
                    }
                    );
            }
            db.SaveChanges();
        }
        private static Dictionary<string, Category> category;
         public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category==null)
                {
                        var list = new List<Category>
                    {
                        new Category {CategoryName = "Электромобили",Desc = "Современный вид транспорта"},
                        new Category {CategoryName = "Классические автомобили",Desc = "Машины с двигателем внутреннеого сгорания"},
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.CategoryName, el);
                }
                return category;
            }
        }
    }
}
