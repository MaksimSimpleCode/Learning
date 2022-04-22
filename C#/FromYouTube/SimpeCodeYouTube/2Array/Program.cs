using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Array       //Двумерный массив
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3] { { 1, 423, 12 }, { 32, 54, 83 }, { 53, 12, 53 } };      //Двумерный массив
            int height = myArray.GetLength(0);      //Высота массива
            int widht = myArray.GetLength(1);       //Ширина массива

            for(int i = 0; i<height;i++)
            {
                for(int j = 0;j<widht;j++)
                {
                    Console.Write(myArray[i, j]+"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(myArray.GetType());
        }
    }
}
