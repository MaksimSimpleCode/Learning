using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    static class Extensionn
    {
        public static void Print (this DateTime dateTime)       //Метод разширения для класса DateTime
        {
            Console.WriteLine(dateTime);
        }
    }
}
