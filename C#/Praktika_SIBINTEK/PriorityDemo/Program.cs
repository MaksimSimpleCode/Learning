using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PriorityDemo
{
    class MyThread
    {
        public int Count;
        public Thread Thrd;
        static bool stop = false;
        static string currentName;
        /* Сконструировать новый поток. Обратите внимание на то, что
        данный конструктор еще не начинает выполнение потоков. */
        public MyThread(string name)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            currentName = name;
        }
        // Начать выполнение нового потока.
        void Run()
        {
            Console.WriteLine("Поток " + Thrd.Name + " начат.");
            do
            {
                Count++;
                if (currentName != Thrd.Name)
                {
                    currentName = Thrd.Name;
                    Console.WriteLine("В потоке " + currentName);
                }
            } while (stop == false && Count < 1000000000);
            stop = true;
            Console.WriteLine("Поток " + Thrd.Name + " завершен.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread mt1 = new MyThread("с высоким приоритетом");
            MyThread mt2 = new MyThread("с низким приоритетом");
            // Установить приоритеты для потоков.
            mt1.Thrd.Priority = ThreadPriority.Highest;
            mt2.Thrd.Priority = ThreadPriority.BelowNormal;
            // Начать потоки.
            mt1.Thrd.Start();
            mt2.Thrd.Start();
            mt1.Thrd.Join();
            mt2.Thrd.Join();
            Console.WriteLine();
            Console.WriteLine("Поток " + mt1.Thrd.Name + " досчитал до " + mt1.Count);
            Console.WriteLine("Поток " + mt2.Thrd.Name +
            " досчитал до " + mt2.Count);
        }
    }
}
    

