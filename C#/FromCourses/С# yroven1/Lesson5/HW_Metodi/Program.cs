using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Metodi
{
    class Program
    {
        static string Legiht(string slovo)
        {
            int count = 10;
            slovo = Console.ReadLine();
            if (slovo.Length > count)
                Console.WriteLine("Слово больше 10 символов");
            else Console.WriteLine("Длина слова меньше 10. Все в норме.");
            return slovo;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово: ");
            string localslovo = "";
            Legiht(localslovo);
            Console.ReadLine();

        }
    }
}
