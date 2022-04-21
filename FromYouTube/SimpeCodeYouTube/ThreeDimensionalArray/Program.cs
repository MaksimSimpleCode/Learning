using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimensionalArray     //Трехмерный массив
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray =       // заполнение трехмерного массива
            {
                { {32,43},{23,24} },
                { {34,32},{52,42} },
                { {32,74},{53,76} }
            };


            for (int i = 0; i < myArray.GetLength(0); i++)      //Вывод трехмерного массива
            {
                Console.WriteLine("Страница №:" + (i + 1));
                for (int J = 0; J < myArray.GetLength(1); J++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, J, k]+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("=======================================");
            }


            Console.ReadLine();
        }
    }
}
