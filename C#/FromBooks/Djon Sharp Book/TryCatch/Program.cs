using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int v = 10;
                int a = int.Parse(Console.ReadLine());
                v += a;
                Console.WriteLine(v);
                
            }
            catch (FormatException exx)
            {
                string error = exx.Message;  // чтобы показать метод Message
                Console.WriteLine(error);   //можно указать просто exx
            }
            Console.ReadKey();

        }
    }
}
