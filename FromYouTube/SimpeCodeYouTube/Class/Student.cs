using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine("Информация о студенте");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Отчество: {middleName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Группа: {group}");
        }

        public string GetFullName()
        {
            return $"{firstName}, {lastName}, {middleName}";
        }
    }
}
