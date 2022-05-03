using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBubbleSort
{
    class Program
    {
        static int[] BubbleSort(int[] mas)  //Алгоритм сортировки пузырьковым методом
        {
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = 0; j < mas.Length - i - 1; j++)
                {
                    if (mas[j + 1] < mas[j])
                    {
                        temp = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5] { 231, 53, -4, 0, 2 };
            Console.WriteLine("До сортировки: ");
            foreach (var item in arr)
                Console.Write(" " + item);

            BubbleSort(arr);

            Console.WriteLine("\nПосле сортировки: ");
            foreach (var item in arr)
                Console.Write(" " + item);

        }
    }
}
