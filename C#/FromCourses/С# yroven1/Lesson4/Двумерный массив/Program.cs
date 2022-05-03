using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумерный_массив
{
    class MyArrayTwoDim
    {
        int[,] a;
        public MyArrayTwoDim(int n, int el)
        {
            a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; i++)
                    a[i, j] = el;
        }

        public MyArrayTwoDim(int n, int min, int max)
        {
            a = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = rnd.Next(min, max);
        }
        public int Min
        {
            get
            {
                int min = a[0, 0];
                //Находим минимальный эллемент
                //В двухмерном массиве для получения размерности нужно использвать
                //метод GetLegnht, а в скобках указывать измерение 
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] < min) min = a[i, j];

                return min;
            }

        }

        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > max) max = a[i, j];

                return max;
            }

        }


        //Свойство подсчет количество положительных
        public int CountPositive
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > 0) count++;
                return count;
            }

        }

        //Свойство подсчет среднего арифметического
        public double Average
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        sum += a[i, j];
                return sum / a.GetLength(0) / a.GetLength(1);

            }

        }

        //Метод который возвращает массив в виде строки
        public string ToString()
        {
            string s = "";
            for (int i = 0; i < a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    s += a[i, j] + " ";
                s += "\n"; // переход на новую строчку
            }
            return s;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayTwoDim a = new MyArrayTwoDim(2, 0, 10);
            Console.WriteLine(a.ToString());
            Console.WriteLine("\nМакимальный элемент: ",a.Max);
            Console.WriteLine("\nМинимальный элемент: ",a.Min);
        }
    }
}
