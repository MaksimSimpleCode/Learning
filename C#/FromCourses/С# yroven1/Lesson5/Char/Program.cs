using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Первая строка";
            string str2 = string.Copy(str1);
            string str3 = "Вторая строка";
            string str4 = "ВТОРАЯ строка";
            string strUp, strLow; ;
            int result, idx;
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("Длина строки str1: " + str1.Length);
            //Создаем прописную и строчную версию строки str1
            strLow = str1.ToLower();
            strUp = str1.ToUpper();
            Console.WriteLine("Строчная вестия строки str1: "+strLow);
            Console.WriteLine("Прописная вестия строки str1: " + strUp);
            Console.WriteLine();
            //Сравниваем строки
            result = str1.CompareTo(str3);
            if (result == 0) Console.WriteLine("str1 и str3 равны");
             else if (result < 0) Console.WriteLine("str1 меньше, чем str3");
                else Console.WriteLine("str1 больше чем str3");
            Console.WriteLine();
            //Сравниваем строки без учета регистра 
            result = String.Compare(str3,str4,true);
            if (result == 0) Console.WriteLine("str3 и str4 равны без учета регистра.");
            else Console.WriteLine("Часть str1 и str2 не равны");
            Console.WriteLine();

            //Поиск строк
            idx = str2.IndexOf("Строка");
            Console.WriteLine("Индекс первого вхождения подстроки строка: " + idx);
            idx = str2.LastIndexOf("о");
            Console.WriteLine("Индекс последнего вхождения символа о: " + idx);
            //Конкатенация
            string str = String.Concat(str1, str2, str3, str4);
            Console.WriteLine(str);
            //удаление подстроки
            str = str.Remove(0, str1.Length);
            Console.WriteLine(str);
            //Замена подстроки "строка" на пустую подстроку
            str = str.Replace("строка", "");
            Console.WriteLine(str);
            Console.ReadKey();


        }
    }
}
