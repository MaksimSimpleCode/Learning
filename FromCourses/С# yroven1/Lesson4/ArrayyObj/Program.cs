using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayyObj
{
    class Program
    {
        static void Print(int[] a)// передаем ссылку на массив
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
        }

        static void Change(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    a[i] =  a[i];
                }
            }
        }

        static void Main(string[] args)
        {
            int[] A = { 0, -1, -2, 3, 4, 5, -6, -7, 8, -9 };
            Print(A);
            Change(A);
            Print(A);
        }
    }
}
