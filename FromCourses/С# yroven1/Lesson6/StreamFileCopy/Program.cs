using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Поиск всех числе в файле

namespace StreamFileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileln = new StreamReader("hobbit.txt");
            StreamWriter fileOut = new StreamWriter("numbers.txt", false);
            string text = fileln.ReadToEnd();
            Regex r = new Regex(@"[-+]?\d+");
            Match integer = r.Match(text);
            while(integer.Success)
            {
                Console.WriteLine(integer);
                fileOut.WriteLine(integer);
                integer = integer.NextMatch();
            }
            fileln.Close();
            fileOut.Close();
            Console.ReadKey();
        }
    }
}
