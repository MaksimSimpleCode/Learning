using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwLesson35_Method_    
    /*
     * 1. Написать метод который выводит на экран строку.       (легкое задание, не стал делать)
     *    Символы из которых состоит строка и их количество вводятся пользователем
     * 
     * 2. Написать метод для поиска индекса массива(тип элементов в массиве - int),     +
     *    метод должен вернуть индекс первого найденного элемента (если он будет найден)
     */
{
    class Program
    {
        static int Index (int[] myArray,int a)
        {
            //Метот нахождения индекса с помощью класса Array и собственно самого IndexOF

            //int result = Array.IndexOf(myArray, a);
            //if (result >= 0)
            //{
            //    return result;
            //}
            //else
            //    return -1;
            //-----------------------------------------------------------------------------

            //Самописный метод нахождения индекса 

            int result = 0;
            for(int i=0;i<myArray.Length;i++)
            {
                if (myArray[i] == a)
                {
                    result= i;
                    break;
                }
                else
                {
                    result= -1;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 6, 3, 4, 6 };

            int indx = Index(myArray, 6);
        }
    }
}
