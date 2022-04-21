using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorklesson1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double i;
            double m;
            double h;
            
            Console.WriteLine("Введите ваш рост: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш вес: ");
            m = Convert.ToInt32(Console.ReadLine());
            i = m / (h * h);
            Console.WriteLine("Индекс массы равен: {0:F4} ",i);

            Console.ReadKey();
        }
    }
}
