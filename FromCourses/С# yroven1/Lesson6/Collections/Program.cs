using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Reader
{
    class Student
    {
        string firstName;
        string secondName;
        string univercity;
        string faculty;
        string departament;
        int age;
        int course;
        int group;
        string city;

        public Student (string firstName, string secondName, string univercity, string faculty, string departament, int age, int course, int group, string city)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.univercity = univercity;
            this.faculty = faculty;
            this.departament = departament;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }

        public override string ToString()
        {
            return firstName + " " + secondName + " " + univercity;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            string text = File.ReadAllText("C:\\123\\data.csv", System.Text.Encoding.Default);
            char[] split = {';', '\n','r' };
            string[] data = text.Split(split,StringSplitOptions.RemoveEmptyEntries);
            int k = 10;
            for (int i = 0; i < 2; i++)
            {

                Student student = new Student(data[k], data[k + 1], data[k + 2], data[k + 3], data[k + 4], int.Parse(data[k + 5]), int.Parse(data[k + 6]), int.Parse(data[k + 7]), data[k + 8]);
                list.Add(student);
                k += 10;
            }
                
                foreach (Student s in list)
                {
                    Console.WriteLine(s.ToString());
                }
            
            Console.ReadKey();
        }
    }
}
