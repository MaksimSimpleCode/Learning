using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MoreThreads
{
    class MyThread
    {
        public int Count;
        public Thread Thrd;
        public MyThread(string name)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }
        // Точка входа в поток.
        void Run()
        {
            Console.WriteLine(Thrd.Name + " начат.");
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("В потоке " + Thrd.Name + ", Count = " + Count);
                Count++;
            } while (Count < 10);
            Console.WriteLine(Thrd.Name + " завершен.");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток начат.");
            // Сконструировать три потока.
            MyThread mt1 = new MyThread("Потомок #1");
            MyThread mt2 = new MyThread("Потомок #2");
            MyThread mt3 = new MyThread("Потомок #3");
            do
            {
                Console.Write(".");
                Thread.Sleep(100);
            } while (mt1.Count < 10 ||
            mt2.Count < 10 ||
            mt3.Count < 10);
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
