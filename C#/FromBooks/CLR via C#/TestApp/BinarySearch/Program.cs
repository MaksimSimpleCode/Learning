using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1,5, 8, 22,35, 38, 55, 92, 98, 99 };

            var test = BinarySearch(array, 99);
            Console.WriteLine(test);
        }
        
        static int? BinarySearch(int [] array, int item)
        {
            int low = 0;
            int high = array.Length -1;

            while (low <= high)
            {
                int mid = (low + high)/2;   //Магия здесь
                int guess = array[mid];
                if (guess == item)
                {
                    return mid;
                }
                    
                if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return null;
        }
    }
}
