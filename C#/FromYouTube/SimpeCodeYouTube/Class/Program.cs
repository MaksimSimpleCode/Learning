using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class //ООП, объекты, классы
{
    enum Color
    {
        Red,
        Green,
        Orange,
        Yellow,
        Blue
    }
    class Point //Класс Point
    {
        public int x;  //Поле класса
        public int y;
        public Color color;

    }

    class Program
    {
        static Student GetStudent()
        {
            var student = new Student();
            student.id = Guid.NewGuid();
            student.group = "group_1";
            student.age = 19;
            student.firstName = "Maksim";
            student.lastName = "Gusev";
            student.middleName = "Andreevych";
            return student;
        }

        //static void Print(Student student)
        //{
        //    Console.WriteLine("Информация о студенте");
        //    Console.WriteLine($"Id: {student.id }");
        //    Console.WriteLine($"Имя: {student.firstName}");
        //    Console.WriteLine($"Фамилия: {student.lastName}");
        //    Console.WriteLine($"Отчество: {student.middleName}");
        //    Console.WriteLine($"Возраст: {student.age}");
        //    Console.WriteLine($"Группа: {student.group}");
        //}
        static void Main(string[] args)
        {
            Point p = new Point();      //Экземпляр класса
            p.x = 4;
            p.y = 2;
            p.color = Color.Orange;

            Point p2 = new Point();     //Экземпляр класса
            p2.x = 2;
            p2.y = 6;
            p2.color = Color.Green;

            Console.WriteLine($"X:{p.x} | Y: {p.y} | Color: {p.color}");
            Console.WriteLine($"X:{p2.x} | Y: {p2.y} | Color: {p2.color}");

            Console.WriteLine("==========================================");
            var firstStudent = GetStudent();    //Первый студент заводиться с помощью метода где жестко прописанны данные.
            firstStudent.Print();

            Console.WriteLine();
            Console.WriteLine();

            var secondStudents = new Student();     // Второй студент
            secondStudents.firstName = "Noname";
            secondStudents.Print();

            string fullName = firstStudent.GetFullName();
            Console.WriteLine(fullName);
        }
    }
}
