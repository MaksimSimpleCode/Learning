using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> book = new Dictionary<string, double>();
            book["apple"] = 0.67;
            book["milk"] = 1.49;
            book["avocado"] = 1.49;

            foreach(var i in book)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
            
        }
    }
}
