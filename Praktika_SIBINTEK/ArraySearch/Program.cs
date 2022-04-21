using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySearch   //Поиск числа в массиве
{
    class MyArray
    {
       static public void SearchArray(int[] arr,int i)
        {
            int index = 0;
            bool flag=false;

            foreach(var item in arr)
            {
                if (item == i)
                {
                    flag = true;
                    break;
                }
            }
            if (flag==true)
            {
                Console.WriteLine("Число найдено");
                Console.WriteLine("Число: " + i);
                Console.WriteLine("Индекс числа: " + Array.IndexOf(arr,i));
               
            }
            else
                Console.WriteLine("Число не обнаружено");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = new int[] {1,2,3,4,5};
            MyArray.SearchArray(myarr, 5);
        }
    }
}
