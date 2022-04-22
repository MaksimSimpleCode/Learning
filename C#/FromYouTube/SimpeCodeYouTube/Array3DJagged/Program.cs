using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3DJagged     //Зубчатый трехмерный массив
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[][][] myArray = new int[rnd.Next(3, 6)][][];

            for (int i = 0; i < myArray.Length; i++)        //Заполняем массив рандомно 
            {
                myArray[i] = new int[rnd.Next(2, 6)][];
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = new int[rnd.Next(3, 6)];

                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        myArray[i][j][k] = rnd.Next(100);

                    }
                }

            }

            for (int i = 0; i < myArray.Length; i++)        //Выводим массив
            {
                Console.WriteLine("Страница №: "+(i+1));
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        Console.Write(myArray[i][j][k]+" ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===========================");
            }
        }
    }
}
