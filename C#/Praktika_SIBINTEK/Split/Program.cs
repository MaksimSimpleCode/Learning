using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn
{
    class Program
    {
        static string GetLastHalf(string text)
        {
            string t = text.Substring(text.Length / 2);

            return t.Replace(" ", "");

        }
        static void Main(string[] args)
        {

            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
            int a = 2;
            Console.WriteLine(a++ + ++a);


        }
    }
}
