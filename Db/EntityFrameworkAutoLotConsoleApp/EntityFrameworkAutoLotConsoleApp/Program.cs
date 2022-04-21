using System;
using EntityFrameworkAutoLotConsoleApp.EF;
//using EntityFrameworkAutoLotConsoleApp.Models;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace EntityFrameworkAutoLotConsoleApp
{
   
    class Program
    {
        private static int AddNewRecord()
        {
            //Добавить запись в таблицу Inventory бахы данных AutoLot
            using (var context = new AutoLotEntities())
            {
                try
                {
                    //В целях тестирования жестко закодировать данные для новой записи
                    var car = new Car() { Make = "Yugo", Color = "Brown", CarNickName = "Brownie" };
                    context.Cars.Add(car);
                    context.SaveChanges();
                    //в случае успешного сохранения EF заполняет поле идентификатора 
                    //значением, сгенерированным базой данных.
                    return car.CarId;
                }
                catch (Exception ex)
                {
                    WriteLine(ex.InnerException?.Message);
                    return 0;
                }
            }
        }

        private static void AddNewRecords(IEnumerable<Car> carsToAdd)
        {
            using(var context = new AutoLotEntities())
            {
                context.Cars.AddRange(carsToAdd);
                context.SaveChanges();
            }
        }

        private static void PrintAllInventory()
        {
            //Выбрать все элементы из таблицы Inventory базы данных AutoLot
            //и вывести данные с приминением специального метода ToString();
            using(var context= new AutoLotEntities())
            {
                foreach(Car c in context.Cars)
                {
                    WriteLine(c);
                }
            }
        }

        private static void PrintBMWInInventory()
        {
            //Используем LINQ
            using (var context = new AutoLotEntities())
            {
                foreach (Car c in context.Cars.Where(c => c.Make == "BMW"))
                    WriteLine(c);
            }
        }

        private static void FunWithLinqQueries()
        {
            using(var context = new AutoLotEntities())
            {
                //Получить проекцию новых данных
                var colorsMakes =
                    from item in context.Cars select new { item.Color, item.Make };
                foreach(var item in colorsMakes)
                {
                    WriteLine(item);
                }

                //Получить только элементы, в которых Color == "Black"
                var blackCars = from item in context.Cars where item.Color == "Black" select item;
                foreach(var item in blackCars)
                {
                    WriteLine(item);
                }
            }    
        }

        private static void RemoveRecord(int carId)
        {
            //Найти запись об автомобиле, подлежащую удалению, по первичному ключу.
            using(var context = new AutoLotEntities())
            {
                //Проверить наличие имени
                Car carToDelete = context.Cars.Find(carId);
                if(carToDelete !=null)
                {
                    context.Cars.Remove(carToDelete);
                    context.SaveChanges();
                    WriteLine($"Запись {carToDelete} удалена!");
                }
            }
        }

        private static void RemoveRecordUsingEntityState(int carId)
        {
            using(var context = new AutoLotEntities())
            {
                Car carToDelete = new Car() { CarId = carId };
                context.Entry(carToDelete).State = EntityState.Deleted;
                try
                {
                    context.SaveChanges();
                }
                catch(DbUpdateConcurrencyException ex)
                {
                    WriteLine(ex);
                }
            }
        }

        private static void UpdateRecord(int carId)
        {
            //Найти запись об автомобиле,подлежащую обновлению по перчичному ключу.
            using(var context = new AutoLotEntities())
            {
                //Получить запись об автомобиле, обновить ее и сохранить!
                Car carToUpdate = context.Cars.Find(carId);
                if(carToUpdate!=null)
                {
                    WriteLine(context.Entry(carToUpdate).State);
                    carToUpdate.Color = "Blue";
                    WriteLine(context.Entry(carToUpdate).State);
                    context.SaveChanges();
                }
                else
                {
                    WriteLine("Запись не обнаружена!");
                }
            }
        }
        static void Main(string[] args)
        {
            WriteLine("****** ADO.NET EF ******\n");
            //int carId = AddNewRecord();
            //WriteLine(carId);
            //PrintAllInventory();
            //RemoveRecord(8);
            //PrintAllInventory();
            //FunWithLinqQueries();
            UpdateRecord(9);
            ReadLine();
        }
    }
}
