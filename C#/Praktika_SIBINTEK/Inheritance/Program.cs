using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        protected string name;
        protected int age;

        public Person (string name,int age) //конструктор класса Person
        {
            this.name = name;
            this.age = age;
        }
    }

    class Worker : Person
    {
        public string position{get;set;}    //Использую автосвойство вместо поля
        //private string position;
        public Worker (string name, int age, string position):base(name,age)    //С помощью ключевого слова BASE мы берем 2 параметра от базового конструктора класса
        {
            this.position = position;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int TestPoleCerezClassDiagramm; //Создал через диаграмму классов.
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker Sam = new Worker(name: "Sam", age: 20, position: "Meneger"); //По приколу использовал именованные параметры
            Console.WriteLine(Sam.Name + " " + Sam.Age + " " + Sam.Position);
        }
    }
}
