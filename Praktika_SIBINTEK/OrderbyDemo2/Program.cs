using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderbyDemo2
{
    // Сортировать результаты запроса по нескольким
    // критериям, используя оператор orderby.
  
    class Account
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Balance { get; private set; }
        public string AccountNumber { get; private set; }
        public Account(string fn, string ln, string accnum, double b)
        {
            FirstName = fn;
            LastName = ln;
            AccountNumber = accnum;
            Balance = b;
        }
    }
    class OrderbyDemo
    {
        static void Main()
        {
            // Сформировать исходные данные.
            Account[] accounts =
            { new Account("Том", "Смит", "132CK", 100.23),
            new Account("Том", "Смит", "132CD", 10000.00),
            new Account("Ральф", "Джонс", "436CD", 1923.85),
            new Account("Ральф", "Джонс", "454MM", 987.132),
            new Account("Тед", "Краммер", "897CD", 3223.19),
            new Account("Ральф", "Джонс", "434CK", -123.32),
            new Account("Capa", "Смит", "543MM", 5017.40),
            new Account("Capa", "Смит", "547CD", 34955.79),
            new Account("Capa", "Смит", "843CK", 345.00),
            new Account("Альберт", "Смит", "445CK", -213.67),
            new Account("Бетти", "Краммер","968MM",5146.67),
            new Account("Карл", "Смит", "078CD", 15345.99),
            new Account("Дженни", "Джонс", "108CK", 10.98)
            };
            // Сформировать запрос на получение сведений о
            // банковских счетах в отсортированном порядке.
            // Отсортировать эти сведения сначала по имени, затем
            // по фамилии и, наконец, по остатку на счете,
            var accInfo = from acc in accounts
                          orderby acc.LastName, acc.FirstName, acc.Balance
                          select acc;
            Console.WriteLine("Счета в отсортированном порядке: ");
            string str = "";
            // Выполнить запрос и вывести его результаты.
            foreach (Account acc in accInfo)
            {
                if (str != acc.FirstName)
                {
                    Console.WriteLine();
                    str = acc.FirstName;
                }
                Console.WriteLine("{0},{1}\tHoмep счета:{2}, {3,10:C}",
                acc.LastName, acc.FirstName,
                acc.AccountNumber, acc.Balance);
            }
            Console.WriteLine();
        }
    }
}
