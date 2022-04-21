using System;
using System.IO;// подключаем пространство имен для работы с  файлами
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Data_primer
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("TextData.txt"); //создаем объект sr и связываем его с data.txt
            //Считаем кол-во чисел.
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(sr.ReadLine());
                Console.WriteLine(a);
                

            }
            
            //Освобождаем файл data.txt для использования другими программами.
            sr.Close();

        }
    }
}
