using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDbContext appDbContext;
        public CarRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Car> Cars => appDbContext.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => appDbContext.Car.Where(p => p.IsFavourite).Include(c => c.Category);

        public Car GetObjectCar(int carId) => appDbContext.Car.FirstOrDefault(p=>p.Id== carId);
    }
}
