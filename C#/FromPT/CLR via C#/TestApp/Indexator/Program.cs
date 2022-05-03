using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexator
{
    class Program
    {
        static void Main(string[] args)
        {
            var microsoft = new Company(new[]
             {
                new Person("Tom"), new Person("Bob"), new Person("Sam"), new Person("Alice")
            });
            // получаем объект из индексатора
            Person firstPerson = microsoft[0];
            Console.WriteLine(firstPerson.Name);  // Tom
                                                  // переустанавливаем объект
            microsoft[0] = new Person("Mike");
            Console.WriteLine(microsoft[0].Name);  // Mike
        }
  
    }
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
    class Company
    {
        Person[] personal;
        public Company(Person[] people) => personal = people;
        // индексатор
        public Person this[int index]
        {
            get => personal[index];
            set => personal[index] = value;
        }
    }

}
