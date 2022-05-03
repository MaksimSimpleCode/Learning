using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwLesson26
{
    class Program
    {
        /*
         * 1)Заполнить массив с клавиатуры  +
         * 2)Вывести массив в обратном порядке  +
         * 3)Найти сумму чисел в массиве +
         * 4)Найти наименьшее число в массиве +
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива\t");
            int size = int.Parse(Console.ReadLine());

            //Заполнение массива с клавиатуры
            int[] myArray = new int[size];

            for(int i =0;i<myArray.Length;i++)
            {
                Console.Write("\nВведите элемент массива № {0}: ", i);
                myArray[i]= int.Parse(Console.ReadLine());
            }
            

            Console.WriteLine("\n--------------------------------------------------------------");
            // Вывод массива в обратном порядке
            Console.Write("Массив \"myArray\" в обратном порядке: ");
            for (int i = myArray.Length-1;i>=0;i--)     
            {
                Console.Write(" "+ myArray[i]);
            }

            Console.WriteLine("\n--------------------------------------------------------------");
            // Сумма числел в массиве и четных чисел
            int sum = 0;    
            int result = 0;
            for (int i = 0; i<myArray.Length;i++)
            {
                sum += myArray[i];

                if (myArray[i] % 2== 0)
                    result += myArray[i];
            }
            Console.WriteLine("Сумма всех элементов массива: "+sum);
            Console.WriteLine("Сумма всех ЧЕТНЫХ элементов массива: " + result);

            Console.WriteLine("\n--------------------------------------------------------------");
            int min= myArray[0];
            for(int i = 0; i<myArray.Length;i++)
            {
                if (myArray[i] <= min)
                    min = myArray[i];
            }
            Console.WriteLine("Минимальный элемент массива: " + min);

            int min2 = myArray.Min();   //Минимальный элемент массива через одно из свойств массива
            Console.WriteLine("Минимальный элемент массива вторым способом: "+min2);
        }
    }
}
