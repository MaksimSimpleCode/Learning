using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var films = new List<Film>
            {
                new Film{Name="Jaws",Year=1975},
                new Film{Name="Singing in the  Rain",Year=1952},
                new Film{Name="Some like is Hot",Year=1959},
                new Film{Name="The wizard of Oz",Year=1939},
                new Film{Name="American Beauty",Year=1999},
                new Film{Name="High Fidelity",Year=2000},
                new Film{Name="The usual sss",Year=2005}
            };
            //Создаем делегат и анонимный метод
            Action<Film> print = film => Console.WriteLine($"Name: {film.Name}, Year: {film.Year}");
            films.ForEach(print);

            Console.WriteLine("--------------------");
            films.FindAll(film => film.Year >= 2000).ForEach(print);

            Console.WriteLine("--------------------");
            films.Sort((f1, f2) => f1.Name.CompareTo(f2.Name));
            films.ForEach(print);

            Console.WriteLine("--------------------");
            films.Sort((f1, f2) => f1.Year.CompareTo(f2.Year));
            films.ForEach(print);


            string str1 = "Привет!";
            string str2 = "При";
            Expression<Func<string,string,bool>> expression = (x, y) => x.StartsWith(y);    //Создаем выражение
            var compiled = expression.Compile();                                            //Компилируем с помощью древа выражений
            Console.WriteLine(compiled(str1,str2));                                     
        }
    }
    class Film
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
}
