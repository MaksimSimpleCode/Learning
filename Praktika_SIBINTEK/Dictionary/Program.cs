using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать словарь для хранения имен и фамилий
            // работников и их зарплаты.
            Dictionary<string, double> dict =
            new Dictionary<string, double>();
            // Добавить элементы в коллекцию.
            dict.Add("Батлер, Джон", 73000);
            dict.Add("Шварц, Capa", 59000);
            dict.Add("Пайк, Томас", 45000);
            dict.Add("Фрэнк, Эд", 99000);

            // Получить коллекцию ключей, т.е. фамилий и имен.
            ICollection<string> с = dict.Keys;
            // Использовать ключи для получения значений, т.е. зарплаты.
            foreach (string str in с)
                Console.WriteLine("{0}, зарплата: {1:C}", str, dict[str]);
        }
    }
}
