using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "123Hello!,Foreach";
            foreach (char c in s) 
            {
                if (char.IsDigit(c)) continue;
                if(c == '!') break;
                Console.Write("{0}", c); 
            }
                Console.ReadKey();
          }
    }
}
