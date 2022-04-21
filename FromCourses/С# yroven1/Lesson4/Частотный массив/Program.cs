using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Частотный_массив
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N = 10;
            int[] a = new int[N];
            //Заполняем массив случайными числами
            for (int i = 0; i < N; i++)
            {
                a[i] = rnd.Next(0, 100);
            }
            //Выводим массив на экран
            foreach (var v in a)
            {
                Console.Write(v + " ");
            }
            //Создаем частотный массив от 0 до 99
            int[] mass = new int[100];
            //Подсчитываем вхождение элементов
            foreach (var v in a) mass[v]++; //Эллемент массива а является номером в частотном массиве mass
            //Находим максимальный эллемент в частотном массиве 
            int imax = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > mass[imax]) imax = i;
            }
            //Выводим все эллементы, которые в частном массиве встречались тоже количество раз, что и imax количество раз
            for (int i = 0; i < mass.Length; i++) 
            if (mass[i] == mass[imax]) Console.WriteLine("\n" + i);
        }
    }
}
