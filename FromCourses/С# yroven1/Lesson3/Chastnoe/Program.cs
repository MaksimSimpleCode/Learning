using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chastnoe
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int d = 3;
            //a/d
            int r = a, q = 0;
            while (r >= d)
            {
                r = r - d;
                q++;
            }
            Console.WriteLine("Частное{0}.\nОстаток{1}", q, r);
        }
        
    }
}
