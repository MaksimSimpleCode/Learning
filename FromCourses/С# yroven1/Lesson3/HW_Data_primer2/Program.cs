using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Data_primer2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Text.txt");
            int sum = 0, count = 0;
            while (!sr.EndOfStream)// Пока не конец потока(файла)
            {
                string s = sr.ReadLine();
                Console.WriteLine("Считали строку: " + s);
                try
                {
                    int a = int.Parse(s);
                    sum = sum + a;
                    count++;
                    Console.WriteLine("{0}.Преобразовали в число:{1},", count, a);
                }
                //В экземпляре exc класса Exception будет
                // храниться информация об ошибке
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

            sr.Close();
            Console.WriteLine("Среднее арифметическое:{0:f2}", (double)sum / count);
            Console.ReadKey();
            //Обратите внимание! Если не поставить явное приобразование типов перед sum, то sum/count
            //получит целое число.Попробуйте убрать(double) перед sum.
        }
        
    }
}
