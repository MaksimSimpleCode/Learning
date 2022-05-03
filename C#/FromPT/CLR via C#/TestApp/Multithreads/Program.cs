using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreads
{
    class Program
    {

        static void Main(string[] args)
        { 
            Task.Run(() => Print()
            ); 

            while (true)
            {
                Console.WriteLine("Первичный"+ " Thread id: " + Thread.CurrentThread.GetHashCode());

            }
        }

        static void Print()
        {
            while (true)
            {
                Console.WriteLine(new string(' ',10)+ "Вторичный"+ " Thread id: "+ Thread.CurrentThread.GetHashCode());
                
            }
        }
    }
}
