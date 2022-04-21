using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance   //Наследование 
{//Несколько классов, наследуют друг друга
    class Person
    {
        private string name;
        private string lastName;
        public Person ()
        {

        }

        public Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public void Print()
        {
            Console.WriteLine("Я здесь работаю");
        }

        public void PrintFullName()
        {
            Console.WriteLine(name + " " + lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Security person1 = new Security { Name = "Bob", LastName = "Djim", Salary = 31244 };    //Сокращенная запись передачи свойств
            Theacher person2 = new Theacher { Name = "Jon", LastName = "Gili", Salary = 50000 };

            person1.PrintFullName();
            person1.Print();
            person1.Guard();
            person1.PrintSalary();
            

            person2.PrintFullName();
            person2.Print();
            person2.Theatcher();
            person2.PrintSalary();
        }
    }
}
