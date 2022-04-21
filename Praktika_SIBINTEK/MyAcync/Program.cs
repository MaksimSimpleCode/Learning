using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyAcync   //Самостоятельно попробую сделать асинхронные вызовы.
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Начало основного потока #1");
            DoWorkAsyc();   //асинхронный метод без параметров
            DoWorkAsyc2(20);//асинхронный метод с параметрами
            Console.WriteLine("Продолжаем основной поток");

            for (int i = 0;i<10;i++)
            {
                Console.WriteLine("Поток #1");
                Thread.Sleep(100);  //имитация долгой работы
            }
            Console.WriteLine("Конец основного потока #1");

            //DoWork();
            
            Console.ReadLine();

        }
        //Версия без параметров
        #region Version without parametres
        public static async Task DoWorkAsyc()   // Асинхронная обертка метода DoWork
        {
            Console.WriteLine("Начало асинхронного потока #2");   //выполняется синхронно
            await Task.Run(() => DoWork()); // выполняется асинхронно 
            Console.WriteLine("Конец асинхронного  потока #2");
        }


        public static void DoWork()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток #2");
                Thread.Sleep(50);//имитация долгой работы
            }
            
        }

        #endregion

        //Версия с параметрами
        #region Version with parameters
        public static async Task DoWorkAsyc2(int max)   // Асинхронная обертка метода DoWork
        {
            Console.WriteLine("Начало асинхронного потока #3");   //выполняется синхронно
            await Task.Run(() => DoWork2(max)); // выполняется асинхронно 
            Console.WriteLine("Конец асинхронного потока #3");
        }

        public static void DoWork2(int max)
        {

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Поток #3");
                Thread.Sleep(50);//имитация долгой работы
            }

        }
        #endregion
    }
}

//Просто пример того что асинхронный метод может выполнять асинхронные задачи паралельно:

//static async void FactorialAsync()
//{
//    Task t1 = Task.Run(() => Factorial(4));
//    Task t2 = Task.Run(() => Factorial(3));
//    Task t3 = Task.Run(() => Factorial(5));
//    await Task.WhenAll(new[] { t1, t2, t3 });
//}