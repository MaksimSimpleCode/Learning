using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_an_array_to_a_power
{
    class Program
    {

        public static int[] GetPoweredArray(int[] arr, int power)
        {
            int[] secondArray = new int[arr.Length];
            int n = 0;
            for (int i = 0; i<arr.Length;++i)
            {
               ++n;
                secondArray[i] = n;
            }
            for(int j = 0; j<arr.Length;j++)
            {
                secondArray[j] = (int)Math.Pow(j+1, power);
            }
            
            foreach(int cr in secondArray)
            {
                Console.WriteLine(cr);
            }
            return secondArray;
        }


        static void Main(string[] args)
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(GetPoweredArray(arrayToPower, 2));
        }
    }
}
