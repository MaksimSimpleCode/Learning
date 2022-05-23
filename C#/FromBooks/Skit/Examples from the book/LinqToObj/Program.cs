using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObj
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection=Enumerable.Range(0, 10);
            //foreach (var el in collection)
            //{
            //    Console.WriteLine(el);
            //}

            //foreach (var el in collection.Reverse().Where(n=>n<5))
            //{
            //    Console.WriteLine(el);
            //}

            //Проецируем новый объект
            foreach (var el in collection.Reverse().Select(x=> new {Original = x, SquareRoot=Math.Sqrt(x)}))
            {
                Console.WriteLine($"Original: {el.Original}, Sqrt: {el.SquareRoot}");
            }

            //Так можем присвоить проекцию
            //var collection2 = collection.Reverse().Select(x => new { Original = x, SquareRoot = Math.Sqrt(x) });

            
        }
    }
}
