using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structura
{
    class Program
    {
        static void doWork()
        {
            //Month first = Month.December;
            //Console.WriteLine(first);
            //first++;
            //Console.WriteLine(first);

            //Date defaultDate = new Date();
            //Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2015, Month.July, 4);
            Console.WriteLine(weddingAnniversary);

            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");
            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is{ weddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniversaryCopy}");
        }


        static void Main(string[] args)
        {
            doWork();
        }
    }
}
