using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyThread  //эксперементирую с потоками
{
    class Program
    {
        static void SecondThread()
        {
            for(int i = 0;i<10;i++)
            {
                Console.WriteLine("                                     Вторичный");
               // Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            Thread myThread = new Thread(SecondThread);
            myThread.Start();
            for(int i = 0;i<10;i++)
            {
                Console.WriteLine("Первый поток");
               // Thread.Sleep(500);
            }

            Console.ReadLine();
        }
    }
}
