using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_yield
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car() {Name = "Ford",Number = "A001AA01"},
                new Car() {Name = "Lada",Number = "B727ET77"}
            };

            var parking = new Parking();
            foreach(var car in cars)
            {
                parking.Add(car);
            }

            foreach(var car in parking)
            {
                Console.WriteLine($"{car.Name} {car.Number}");  //Используем наш енумератор
            }

            Console.WriteLine(parking["A001AA01"]?.Name);   //Применяем индексатор (получение значения)
            Console.WriteLine(parking["B727ET77"]?.Name);   //Применяем индексатор (получение значения)

            Console.WriteLine(parking[1]);  //Применяем индексатор  (получение значения)
            Console.WriteLine("Введите номер нового автомобиля");
            var num =Console.ReadLine();
           
            parking[1] = new Car() { Name = "BMW", Number = num };  //Применяем индексатор (установка значения)
            Console.WriteLine(parking[1]);

            foreach (var car in parking.GetCars())
            {

            }
            Console.ReadLine();


        }
    }
}
