using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Praktika
{
    class Program
    {
        public static int[] GetFirstEvenNumbers(int count)
        {
            // четный массив
            int[] a = new int[count];


            for (int i = 0; i < count; i++)
            {
                a[i] = (i + 1) * 2;


            }
            return a;
        }


        public static int MaxIndex(double[] array)
        {
            // Индекс максимума
            if (array.Length == 0) return -1;
            var max = 0;
            for (int i = 0; i < array.Length; i++)
            {  
                if (array[i] >array[max]) max = i;  
            }
            return max;
        }


        public static int GetElementCount(int[] items, int itemToCount)
        {
            //Подсчет
            return items.Count(x => x == itemToCount);
        }


        static void Main(string[] args)
        {
            int[] items = new[] { 1 };
            GetElementCount(items, 1);
        }
      
    }
}
    
