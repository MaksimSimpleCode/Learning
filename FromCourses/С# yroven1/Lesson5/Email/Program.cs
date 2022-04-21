using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex myReg = new Regex(@"[A-Za-z]+[\.A-Za-z0-9_-]*[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]+");
            Console.WriteLine(myReg.IsMatch("email@email.com"));//True
            Console.WriteLine(myReg.IsMatch("email@email"));    //False
            Console.WriteLine(myReg.IsMatch("@email.com"));     //False

        }
    }
}
