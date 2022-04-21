using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //Можно засечь время выполнения программы следующим образом:
            //Мы засекаем время начала, конца, и вычисляем.
            DateTime start = DateTime.Now;
            //Имитация программы чтобы задать паузу
            System.Threading.Thread.Sleep(4000);
            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start);
            Console.ReadKey();

        }
    }
}
