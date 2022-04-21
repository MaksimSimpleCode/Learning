using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray       //Зубчатый массив
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[3][];

            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < myArray.Length; i++)        //Заполнение зубчатого массива рандомными числами
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = rnd.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)        //Вывод зубчатого массива
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
