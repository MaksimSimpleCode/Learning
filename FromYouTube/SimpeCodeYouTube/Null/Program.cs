using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null      
{
    /*
     * ====
     * Оператор объединения ?? 
     * ====
     */
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }



        static void Main(string[] args)
        {
            string str = null;      // Пустая переменная
            Console.WriteLine(str??"Нет данных");   // Применяю опреатор для присвоения дефолтного значения при null


            string result = str ?? "";     // Еще один способ применения 
            Console.WriteLine("Длинна строки :" + result.Length);   // Теперь вместо ошибки если будет null в длинну строки мы получим 0
            
            //===================================================================================================================================================
            /*
             * ====
             * Оператор присваивания объединения со значением Null ??= 
             * ====
             */

            string strr = null;      
          //  string def = strr ??= "Нет данных";      // Почему то ошибка, должен рабоать как и ?? только в strr присвоит ("Нет данных")
                                                     // UPD: все дело в версии. нужно от 8.0
          //===================================================================================================================================================
            /*
             * ====
             * Оператор условного null ?.
             * ====
             */

            int[] myArray = GetArray();

            Console.WriteLine("Сумма элементов массива " + myArray?.Sum());     // Если NULL то код после ?. не будет выполняться
            Console.WriteLine("Сумма элементов массива " + (myArray?.Sum() ?? 0));      // Комбинируем ?.и ??
        }
    }
}
