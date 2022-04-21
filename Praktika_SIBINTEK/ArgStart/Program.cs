using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ArgStart
{
    class MyThread
    {
        public int Count;
        public Thread Thrd;
        // Обратите внимание на то, что конструктору класса
        // MyThread передается также значение типа int.
        public MyThread(string name, int num)
        {
            Count = 0;
            // Вызвать конструктор типа ParameterizedThreadStart
            // явным образом только ради наглядности примера.
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            // Здесь переменная num передается методу Start()
            // в качестве аргумента.
            Thrd.Start(num);
        }
        // Обратите внимание на то, что в этой форме метода Run()
        // указывается параметр типа object.
        void Run(object num)
        {
            Console.WriteLine(Thrd.Name + " начат со счета " + num);
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("В потоке " + Thrd.Name + ", Count = " + Count);
                Count++;
            } while (Count < (int)num);
            Console.WriteLine(Thrd.Name + " завершен.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Обратите внимание на то, что число повторений
            // передается этим двум объектам типа MyThread.
            MyThread mt = new MyThread("Потомок #1", 5);
            MyThread mt2 = new MyThread("Потомок #2", 3);
            do
            {
                Thread.Sleep(100);
            } while (mt.Thrd.IsAlive| mt2.Thrd.IsAlive);
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
