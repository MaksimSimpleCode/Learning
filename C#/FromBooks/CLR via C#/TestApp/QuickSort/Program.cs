using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 5, 3, 2,4, 43, 21, 33, 53, 89, 90 };
            Console.WriteLine("До соритровки");
            PrintArray(array);

            quicksort(array, 0, array.Length - 1);

            Console.WriteLine("После соритровки");
            PrintArray(array);
        }
        static int partition(int[] array, int start, int end)
        {
            int temp;//swap helper
            int marker = start;//divides left and right subarrays
            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end]) //array[end] is pivot
                {
                    temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            //put pivot(array[end]) between left and right subarrays
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        static void quicksort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            quicksort(array, start, pivot - 1);
            quicksort(array, pivot + 1, end);
        }

        static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
                Console.WriteLine(item);
        }
    }
}
