using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djon_Sharp_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 2;
            //Console.WriteLine("a/b= "+a / b);
            //Console.WriteLine("a%b= " + a % b);

            int i = 2;
            int j = 2;
            int k = 2;

            while (i<10)
            {
               //Console.Write(i);
                i++;
                
                // нужно переходить от цыкла к цыклу с шагом 1?
                while (j<10)
                {
                    Console.Write(j);
                        j++;



                }

                while (k < 10)
                {
                    Console.WriteLine(k);
                    k++;
                }

            }
        }
    }
}
