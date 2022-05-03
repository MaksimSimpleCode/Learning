using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObj
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
        public User()
        {
            Languages = new List<string>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Базовые примеры
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            var selectedTeams = new List<string>();
            foreach (string s in teams)
            {
                if (s.ToUpper().StartsWith("Б"))
                    selectedTeams.Add(s);
            }
            selectedTeams.Sort();

            foreach (string s in selectedTeams)
                Console.WriteLine(s);

            Console.WriteLine();


            var selectedTeams2 = from t in teams // определяем каждый объект из teams как t
                                 where t.ToUpper().StartsWith("Б") //фильтрация по критерию
                                 orderby t  // упорядочиваем по возрастанию
                                 select t; // выбираем объект

            foreach (string s in selectedTeams)
                Console.WriteLine(s);


            int[] arr = { 1, 2, 4, 5, 236, 7, 568, 233, 12, 67, 8, 87, 43 };

            var selectArr = from ithem in arr
                            where ithem % 2 == 0 && ithem > 50
                            select ithem;

            foreach (var i in selectArr)
                Console.WriteLine(i);

            var selectArr2 = arr.Where(i => i % 2 == 0 && i > 50);
            foreach (var i in selectArr2)
                Console.WriteLine(i);

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            #endregion

            List<User> users = new List<User>
            {
                new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };



            var selectedUsers = from user in users
                                from lang in user.Languages
                                where user.Age < 28
                                where lang == "англий"
                                select user;

            foreach (var u in selectedUsers)
            {
                Console.WriteLine($"{u.Name}");
            }
                
        }
    
     }
}
