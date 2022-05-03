using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var products = new List<Product>();
            for (var i = 0; i < 10; i++)
            {

                var product = new Product()
                {
                    Name = "Продукт " + i,
                    Energy = rnd.Next(10, 25)
                };
                products.Add(product);

            }

            var result = from item in products    //1 вариант
                         where item.Energy < 200
                         select item;

            var result2 = products.Where(item => item.Energy < 200 || item.Energy > 300);   //2 вариант с помощью методов разширений

            //foreach (var item in result)
            //    Console.WriteLine(item);
            //Console.WriteLine();
            //foreach (var item in result)
            //    Console.WriteLine(item);


            var selectCollection = products.Select(product => product.Energy);  // Делаем из коллекции продуктов коллекцию только каллорий
            //foreach (var item in selectCollection)
            //    Console.WriteLine(item);

            var orderbyCollection = products.OrderBy(product => product.Energy).ThenBy(product => product.Name);
            //foreach (var item in orderbyCollection)
            //    Console.WriteLine(item);

            var groupByCollection = products.GroupBy(product => product.Energy);

            //foreach( var group in groupByCollection)
            //{
            //    Console.WriteLine($"Ключ: {group.Key}");
            //    foreach(var item in group)
            //    {
            //        Console.WriteLine($"\t{item}");
            //    }
            //}

            Console.WriteLine(products.All(item => item.Energy == 10)); // Если все элементы коллеции =10
            Console.WriteLine(products.Any(item => item.Energy == 10));// Если Хотя бы одна =10
            Console.WriteLine(products.Contains(products[5]));// Входит ли эллемент в коллекцию

            var array = new int[] { 1, 2, 3, 4 };
            var array2 = new int[] { 7, 2, 3, 4, 3, 2, 4, 5, 3,  2 };
            var union = array.Union(array2);// Объединить array самим с array2
            //foreach (var item in union)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(union.Count());

            //var intersect = array.Intersect(array2);// Пересечение двух коллекций
            //foreach (var item in intersect)
            //{
            //    Console.WriteLine(item);
            //}

            var except = array.Except(array2);  //Вычитает из 1 колекции 2 и оставляет то чего нет во второй коллекции
            foreach (var item in except)
            {
                Console.WriteLine(item);
            }
        }
    }
}

