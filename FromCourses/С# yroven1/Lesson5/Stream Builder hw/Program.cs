using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Builder_hw
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                StringBuilder str = new StringBuilder("Площадь");
                PrintString(str);
                str.Append(" треугольника равна");
                PrintString(str);
                str.AppendFormat("{0:f2}см", 123.456);
                PrintString(str);
                str.Insert(8, "данного");
                PrintString(str);
                str.Remove(7, 21);
                PrintString(str);
                str.Replace("а", "о");
                PrintString(str);
                StringBuilder str1 = new StringBuilder(Console.ReadLine());
                StringBuilder str2 = new StringBuilder(Console.ReadLine());
                Console.WriteLine(str1.Equals(str2));
            }
            catch
            {
                Console.WriteLine("Возникло исключение");
            }

        }
        static void PrintString(StringBuilder a)
        {
            Console.WriteLine("Строка: " + a);
            Console.WriteLine("Текущая длина строки:" + a.Length);
            Console.WriteLine("Объем буфера "+ a.Capacity);
            Console.WriteLine("Максимальный объем буфера " + a.MaxCapacity);
            Console.WriteLine();
        }   
    }
}
