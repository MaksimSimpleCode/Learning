using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ArrayKeyboard       //Двумерный массив, ввод с клавиатуры
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3];      //Двумерный массив
            int height = myArray.GetLength(0);      //Высота массива
            int widht = myArray.GetLength(1);       //Ширина массива


            for (int i = 0; i < height; i++)        // Заполняем 2 мерный массив c клавиатуры
            {
                for (int j = 0; j < widht; j++)
                {
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < height; i++)        //вывод двумерного массива
            {
                for (int j = 0; j < widht; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(myArray.GetType());
        }
    }
}
