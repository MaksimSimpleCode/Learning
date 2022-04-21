using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace MultiThreadedPrinting //Проблемы параллелизма
{
    public class Printer
    {
        //Маркер блокировки
        private object threadLock = new object();
        public void PrintNumbers()
        {
            //Использовать маркер блокировки.   Если его закооментировать то столкнемся с проблемой параллелизма
            lock (threadLock)   //можно написать this вместо объекта threadLock. Тут не совсем разобрался...
            {
                //Вывести информацию о потоке
                Console.WriteLine("-> {0} выполняет PrintNumbers", Thread.CurrentThread.Name);
                //Вывести числа
                Console.Write("Твои числа: ");


                for (int i = 0; i < 10; i++)
                {
                    //Приостановить поток на случайный период времени
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(5));
                    Console.Write("{0}, ", i);
                }
                Console.WriteLine();
            }
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("*****Synchronizing Threads *****\n");
                Printer p = new Printer();

                //Создать 10 потоков, которые указывают на один и тот же метод того же самого объекта
                Thread[] threads = new Thread[10];
                for (int i = 0; i < 10; i++)
                {
                    threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                    {
                        Name = $"Рабочий поток #{i}"
                    };
                }
                //Теперь запустить их все
                foreach (Thread t in threads)
                    t.Start();
                Console.ReadLine();
            }
        }
    }
}
