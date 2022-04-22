using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoobleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 5, 3, 7, 9, 1, 2, 3, 4, 6, 8 };

            PrintArr(arr);
            BoobleSort(arr);
            PrintArr(arr);
        }

        static void BoobleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            { 
                if(arr[i]>arr[i+1])
                {
                    var a = arr[i];
                    var b = arr[i + 1];
                    arr[i] = b;
                    arr[i + 1] = a;
                }
            }
        }

        static void PrintArr(int [] arr)
        {
            foreach (var item in arr)
                Console.Write(item);
        }
    }
}
