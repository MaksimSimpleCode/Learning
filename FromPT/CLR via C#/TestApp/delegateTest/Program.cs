using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateTest
{

   public class Program
    {
        public delegate void Message();
        static void Main(string[] args)
        {
            Message hello = () => Console.WriteLine("Hello");
            hello();

            
        }

    }
}
