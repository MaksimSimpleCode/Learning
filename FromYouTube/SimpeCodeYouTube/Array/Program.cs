using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 45, 5 };

            Console.WriteLine(arr[3]);  // Вывод эллемента массива
            arr[3] = 0; // Присвоение значения эллементу массива
            Console.WriteLine(arr[3]);
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",arr));  // Вывод массива без цикла

            
            Console.WriteLine("Максимальное значение массива: "+arr.Max());     // Использую одно из множества свойств массива

            int[] myArray = Enumerable.Repeat(5, 10).ToArray(); // Заполняет массив из 10 элементов, каждый равен 5
            Console.WriteLine(string.Join(" ", myArray));

            int[] myArray2 = Enumerable.Range(5, 10).ToArray(); // Заполняет массив из 10 элементов начиная с 5
            Console.WriteLine(string.Join(" ", myArray2));

            Console.Write("Вывод массива через цикл: ");
            for (int i = 0; i<myArray.Length; i++)       // Вывод массива через цикл
            {
                Console.Write(" "+myArray[i]);
            }
            Console.WriteLine();
        }
    }
}
