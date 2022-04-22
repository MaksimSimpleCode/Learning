using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_and_StringBuilder
{
    class Program
    {
        
            const int iIterations = 20000;
            public static void Main()
        {
            DateTime dt = DateTime.Now;
            string str = String.Empty;
            for (int i = 0; i < iIterations; i++)
                str = str + "abcdifgaherldotmgkeolg\r\n";
            Console.Write("Скорость при использовании String:  ");
            Console.WriteLine(DateTime.Now - dt);

            dt = DateTime.Now;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < iIterations; i++)
                sb.Append("abcdifgaherldotmgkeolg\r\n");
            str = sb.ToString();
            Console.Write("Скорость при использовании StringBuilder:  ");
            Console.WriteLine(DateTime.Now - dt);

        }
        
    }
}
