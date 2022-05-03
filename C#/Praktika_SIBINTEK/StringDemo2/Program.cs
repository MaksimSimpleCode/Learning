using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C# обладает эффективными средствами обработки строк.";
            int idx;
            Console.WriteLine("Строка str: " + str);
            idx = str.IndexOf('о');
            Console.WriteLine("Индекс первого вхождения символа 'o': " + idx);
            idx = str.LastIndexOf('о');
            Console.WriteLine("Индекс последнего вхождения символа 'o': " + idx);
            idx = str.IndexOf("ми", StringComparison.Ordinal);
            Console.WriteLine("Индекс первого вхождения подстроки \"ми\": " + idx);
            idx = str.LastIndexOf("ми", StringComparison.Ordinal);
            Console.WriteLine("Индекс последнего вхождения подстроки \"ми\": " + idx);
            char[] chrs = { 'а', 'б', 'в' };
            idx = str.IndexOfAny(chrs);
            Console.WriteLine("Индекс первого вхождения символов " +
            " 'а', 'б' или 'в': " + idx);
            if (str.StartsWith("C# обладает", StringComparison.Ordinal))
                Console.WriteLine("Строка str начинается с подстроки \"C# обладает!");
            if (str.EndsWith("строк.", StringComparison.Ordinal))
                Console.WriteLine("Строка str оканчивается подстрокой \"строк.\"");
        }
    }
}
