using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwLesson43_ref_ //Домашнее задание по ключевому слову ref
{
    /*
     * 1. Написать метод Resize изменяющий количество элементов массива (метод должен иметь
     *    возможность увеличить или уменьшить количество элементов массива).    +
     *    
     * 2. Написать методы для добавления элемента в начало массива, в конец массива и по указанному индексу.    +
     * 
     * 3. Написать методы для удаления перовго элемента массива, последнего элемента массива и элемента по указаному индексу.   +
     * 
     */
    class Program
    {
        //Задание 1
        static void Resize(ref int[] myArray, int newSize)
        {
            // Суть в том что изменить размер массива нельзя, по этому мы создаем новый, копируем в него значения старого и увеличиваем/уменьшаем.
            int[] newArray = new int[newSize];  //Задаем новый размер
            if(newSize>= myArray.Length)       // Записываем старые данные в новыяй массив если новый размер больше или равен размеру старого массива.
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    newArray[i] = myArray[i];
                }
            }
            else      //иначе просто переписываем данные по новому размеру "Уменьшаем"
            {
                for (int i = 0; i < newSize; i++)
                {
                    newArray[i] = myArray[i];
                }
            }

            myArray = newArray; // заменяем ссылку благодаря ref (теперь имя старого массива ссылается на новый массив)
        }
        //============================================================================================================================================================
        //Задание 2
        static void FirstElementArray(ref int[]myArray,int newElement)  // Добовляем элемент в начало массива
        {
            int[] newArray = new int[myArray.Length+1];
            newArray[0] = newElement;
            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i+1] = myArray[i];
            }

            myArray = newArray;
        }

        static void LastElementArray(ref int[] myArray, int newElement) //Добовляем элемент в конец массива
        {
            int[] newArray = new int[myArray.Length+1];
            newArray[myArray.Length] = newElement;
            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }

            myArray = newArray;
        }

        static void MiddleElementArray(ref int[] myArray, int newElement, int index) //Добовляем элемент по указонному элементу
        {
            int[] newArray = new int[myArray.Length+1];
            newArray[index] = newElement;
            for (int i = 0; i < index; i++)
            {
                newArray[i] = myArray[i];
            }
           
            for (int i = index; i < myArray.Length; i++)
            {
                newArray[i+1] = myArray[i];
            }
            

            myArray = newArray;     //По сути один этот метод может заменить все предыдущие.

            // UPD: Можно предыдущие два метода максимально сократить передавая в них этот метод : MiddleElementArray(ref myArray, newElement,0) 
            //- это для первого элемента, для последнего по аналогии
        }
        //============================================================================================================================================================
        //Задание 3

        static void RemoveElemetArray(ref int[] myArray, int index) //Удаляем элемент по указонному элементу
        {
            int[] newArray = new int[myArray.Length-1];
            for (int i = 0; i < index; i++)     //Заполняю новый массив до индекса
            {
                newArray[i] = myArray[i];
            }

            for (int i = index; i < myArray.Length-1; i++)      //Заполняю от индекса увеличивая шаг по старому массиву на +1
            {
                newArray[i] = myArray[i+1];
            }

            myArray = newArray;
        }

        //Следующие два метода делаю через свой первый метод
        static void RemoveFirstElemetArray(ref int[] myArray) //Удаляем первый элемент.
        {
            RemoveElemetArray(ref myArray, 0);
        }

        static void RemoveLastElemetArray(ref int[] myArray) //Удаляем последний элемент.
        {
            RemoveElemetArray(ref myArray, myArray.Length-1);
        }
        static void Main(string[] args)
        { //Задание 1
            Console.WriteLine("Задание 1: ");
            int[] myArray = { 1,2,3,4,5};
            Console.WriteLine("Количество элементов массива: " + myArray.Length);
            Console.WriteLine(string.Join(" ", myArray) + " - Изначальный массив");

            Resize( ref myArray, 10);
            Console.WriteLine("Количество элементов массива: " + myArray.Length);
            Console.WriteLine(string.Join(" ", myArray) + " - С новым кол-во элементов");

            Console.WriteLine("===================================================");

            //Задание 2
            Console.WriteLine("Задание 2: ");
            int[] myArray2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(" ", myArray2)+" - Изначальный массив");

            FirstElementArray(ref myArray2, 0);
            Console.WriteLine(string.Join(" ", myArray2) + " - После добавления нового 1 элемента в массив");

            LastElementArray(ref myArray2, 6);
            Console.WriteLine(string.Join(" ", myArray2) + " - После добавления нового последнего элемента в массив");

            MiddleElementArray(ref myArray2,300,4 );
            Console.WriteLine(string.Join(" ", myArray2) + " - После добавления выбранного элемента (4) массива");

            Console.WriteLine("===================================================");

            //Задание 3
            Console.WriteLine("Задание 3: ");
            int[] myArray3 = { 0,1, 2, 3,4,5,6,7,8,9,10};
            Console.WriteLine(string.Join(" ", myArray3) + " - Изначальный массив");

            RemoveFirstElemetArray(ref myArray3);
            Console.WriteLine(string.Join(" ", myArray3) + " - После удаления первого элемента");

            RemoveLastElemetArray(ref myArray3);
            Console.WriteLine(string.Join(" ", myArray3) + " - После удаления последнего элемента");

            RemoveElemetArray(ref myArray3, 5);
            Console.WriteLine(string.Join(" ", myArray3) + " - После удаления указанного элемента (5)");
            Console.WriteLine("===================================================");




        }
    }
}
