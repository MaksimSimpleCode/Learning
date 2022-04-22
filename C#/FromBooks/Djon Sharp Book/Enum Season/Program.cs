using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Season
{
    class Program
    {
        static void doWork()
        {
            Month first = Month.December;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
        }

        static void Main(string[] args)
        {
            doWork();
        }
    }
}
