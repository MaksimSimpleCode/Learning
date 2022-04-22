using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car { Name = "Tesla",
                        ShortDesc = "",
                        Img="/img/Cat_clon.jpg",
                        Price=45000,
                        IsFavourite=true,
                        Available=true,
                        Category=_categoryCars.AllCategories.First()
                    },
                    new Car { Name = "Mercedes C Class",
                        ShortDesc = "Уютный и большой",
                        LongtDesc="Удобный автомобиль для города",
                        Img="",
                        Price=65000,
                        IsFavourite=true,
                        Available=true,
                        Category=_categoryCars.AllCategories.Last()
                    }, 
                    new Car { Name = "BMW M3", 
                        ShortDesc = "Дерзкий и стильный",
                        LongtDesc="Удобный автомобиль для города",
                        Img="",
                        Price=60000,
                        IsFavourite=false,
                        Available=false,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
