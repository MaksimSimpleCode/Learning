using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var microsoft = new Company(new Person[] { new Person("Tom"), new Person("Bob"), new Person("Sam") });

            Console.WriteLine(microsoft[0].Name);      // Tom
            Console.WriteLine(microsoft["Bob"].Name);  // Bob
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
        //перегрузка индексатора
        public Person this[string name]
        {
            get
            {
                foreach (var person in personal)
                {
                    if (person.Name == name) return person;
                }
                throw new Exception("Unknown name");
            }
        }
    }
}
