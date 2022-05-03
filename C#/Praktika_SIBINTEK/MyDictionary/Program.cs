using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Person
    {
        private string firstName;
        private string secondName;
        private int age;
        public int Age { get { return age; } }
        private static  int countPerson;    //Приватное статическое поле для подсчета персон

        public static int getNumOfPeople() { return countPerson; }  //Статический метод для подсчета кол-ва персон.

        public Person (string firstName, string secondName, int age)
        {
            countPerson++;  //При каждом заполнении конструктора кол-во персон возрастает
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;

        }
        public override string ToString()   //переопределяю метод ToString для того чтобы выводить на консоль экземпляр класса как мне нужно
        {
            return "Имя: " + firstName + " Фамилия: " + secondName + " Возраст: " + age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            // Наполнить с помощью метода Add().
            peopleA.Add("Homer", new Person ( "Homer", "Simson", 47 ));
            peopleA.Add("Marge", new Person("Marge", "Simson", 45));
            peopleA.Add("Bard", new Person("Bard", "Simson", 8));
            peopleA.Add("Lisa", new Person("Lisa", "Simson", 9));
            // Получить элемент с ключом Homer.
            Person homer = peopleA["Homer"];
            Console.WriteLine(homer.ToString());

            //Наполнить с помощью синтаксиса инициализации.
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                { "Homer",  new Person("Homer", "Simson", 47)},
                { "Marge",  new Person("Marge", "Simson", 45)},
                { "Bard",  new Person("Bard", "Simson", 8)},
                { "Lisa",  new Person("Lisa", "Simson", 9)}
            };

            //Получить эллемент с ключем Lisa.
            Person lisa = peopleB["Lisa"];
            Console.WriteLine(lisa.ToString()+"Кол-во персон: ");

            Console.WriteLine("*********************************************");
            foreach (var list in peopleB)   //Можно вывести весь список
                Console.WriteLine("Ключ: |"+ list.Key+"| Значение: "+list.Value);
            //Для теста, сделал подсчет созданных персон.
            Console.WriteLine("Кол-во персон: "+ Person.getNumOfPeople());
        }
    }
}
