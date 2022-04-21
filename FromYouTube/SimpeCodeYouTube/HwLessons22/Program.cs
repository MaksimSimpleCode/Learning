using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwLessons22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            
            for (int i=0;i<height;i++)
            { 
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int ir = 0; ir < height; ir++)
            {
                for (int jk = height; jk > ir; jk--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
