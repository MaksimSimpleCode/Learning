using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This  //Ключевое слово this
{
    class Student
    {
        private string name;
        private int age;
        private string group;
        private int kurs;

        public Student ()   // Первый конструктор
        {
            name = "Пусто"; // Пустое имя
            age = 18;       // Условно минимальный возраст
        }

        public Student(string name, int age)    //Второй конструктор
        {
            this.name = name;       //КЛЮЧЕВОЕ СЛОВО this используется для того чтобы не было недопонимания в коде(названия переменных одинаковые)
            this.age = age;
        }


        public Student(string name , int age, string group, int kurs) : this(name, age)     //Третий конструктор с использованием КЛЮЧЕВОГО СЛОВА this
        {
            // Здесь мы использовали this для того чтобы не было лишнего кода.Наш конструктор сначала обращается к 2 конструктору, затем к себе
            //Таким образом мы избегаем лишнего объявления полей в конструкторе
            this.group = group;
            this.kurs = kurs;
        }

        public Student (string name, int age, string group):this(name,age)  // Тоже самое, укорачиваем код благодаря this
        {
            this.group = group;
        }

        public Student (string name, int age, int kurs):this(name,age)      // Опять же тоже самое, наследуем все старое у других конструкторов а новое прописываем
        {
            this.kurs = kurs;
        }
       

        public void Print()     //Метод класса в котором описываем вывод исходя из наличия/отсутсвия данных
        {
            if (group == null && kurs==0)
                Console.WriteLine($"Name: {name}, \tAge: {age}, \tGroup: не указана, \tKurs: не указан");
            else if (kurs==0)
                Console.WriteLine($"Name: {name}, \tAge: {age}, \tGroup: {group}, \tKurs: не указан");
            else if (group == null)
                Console.WriteLine($"Name: {name}, \tAge: {age}, \tGroup: не указана, \tKurs: {kurs}");
            else
                Console.WriteLine($"Name: {name}, \tAge: {age}, \tGroup: {group}, \tKurs: {kurs}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Bob", 18);   //Первый студент по 2 конструктору
            student.Print();

            Student student2 = new Student("Karl", 20); //Второй студент по 2 конструктору
            student2.Print();

            Student student3 = new Student();   //Третий студент по 1 конструктору
            student3.Print();

            Student student4 = new Student("Jon",18,"data sciens",1);   //Третий студент по 3 конструктору
            student4.Print();

            Student student5 = new Student("Arnold", 18, "informatiks");
            student5.Print();

            Student student6 = new Student("Gleb", 19, 2);
            student6.Print();
        }
    }
}
