using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStart
{

    class MyThread
    {
        public int Count;
        string thrdName;
        public MyThread(string name)
        {
            Count = 0;
            thrdName = name;
        }
        // Точка входа в поток.
        public void Run()
        {
            Console.WriteLine(thrdName + " начат.");
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("В потоке " + thrdName + ", Count = " + Count);
                Count++;
            } while (Count < 10);
            Console.WriteLine(thrdName + " завершен.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток начат.");
            // Сначала сконструировать объект типа MyThread.
            MyThread mt = new MyThread("Потомок #1");
            // Далее сконструировать поток из этого объекта. Точкой входа задается метод Run() объекта mt.
            Thread newThrd = new Thread(mt.Run);
            // И наконец, начать выполнение потока.
            newThrd.Start();
            do
            {
                Console.Write(".");
                Thread.Sleep(100);
            } while (mt.Count != 10);
            Console.WriteLine("Основной поток завершен.");

           
        }
    }
}
