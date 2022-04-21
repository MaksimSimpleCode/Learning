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
            //массив массивов.
            int[][] a = new int[5][];
            a[0] = new int[4];
            a[1] = new int[5];
            a[2] = new int[3];
            string[] ss = new string[4];
            ss[0] = "hello";
            ss[1] = "world";
            Console.Write(ss[0][0]);


        }
    }
}
