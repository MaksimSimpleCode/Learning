using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 64354.2345;
            Console.WriteLine("Формат по умолчанию: " + num);
            // Отобразить числовое значение с 2 разрядами после десятичной точки.
            Console.WriteLine("Значение с 2 десятичными разрядами: " +
            "(0:#.##)", num);
            // Отобразить числовое значение с 2 разрядами после
            // десятичной точки и запятыми перед ней.
            Console.WriteLine("Добавить запятые: (0:#,###.##}", num);
            // Отобразить числовое значение в экспоненциальном представлении.
            Console.WriteLine("Использовать экспоненциальное представление: " +
            "{0:#.###е+00}", num);
            // Отобразить числовое значение, масштабированное в тысячах.
            Console.WriteLine("Значение в тысячах: " + "(0:#0,)", num);
            /* Отобразить по-разному положительные,
            отрицательные и нулевые значения. */
            Console.WriteLine("Отобразить по-разному положительные," +
            "отрицательные и нулевые значения.");
            Console.WriteLine("{0:#.#;(#.##);0.00}", num);
            num = -num;
            Console.WriteLine("{0:#.##;(#.##);0.00}", num);
            num = 0.0;
            Console.WriteLine("{0:#.##;(#.##);0.00}", num);
            // Отобразить числовое значение в процентах.
            num = 0.17;
            Console.WriteLine("Отобразить в процентах: {0:#%}", num);
        }
    }
}
