using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 257;
            

           byte result = (byte)i;
            Console.WriteLine(result+300);
            Console.WriteLine(result.GetType());

            bool c = true;
            if (c)? Console.WriteLine("1") : Console.WriteLine("1");
        }

        }
    }
}
