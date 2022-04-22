using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array;
            array = new int[3][];
            Console.WriteLine(array.Length);
            Console.WriteLine(array.Rank);

            array[0] = new int[2];
            array[1] = new int[4];
            array[2] = new int[9];
          
            Console.WriteLine(array[0].Length);
            Console.WriteLine(array[1].Length);
            Console.WriteLine(array[2].Length);
        }
    }
}
