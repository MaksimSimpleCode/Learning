using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    //Создаем рандомные группы и студентов и сереализуем это 4 способами
    class Program
    {
        static void Main(string[] args)
        {
            var groups = new List<Group>();
            var students = new List<Student>();
            for( int i = 0; i<10;i++)
            {
                groups.Add(new Group(i, "Группа " + i));
            }

            for (int i = 0; i<300; i++)
            {
                var student = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i % 9]
                };
                students.Add(student);
            }
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------
            //СЕРИАЛИЗАЦИЯ (БИНАРНАЯ)
            var binFormatter = new BinaryFormatter(); //Форматер для сериализации
            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, groups);   //Сериализуем в файл группы
            }
            //ДEСЕРИАЛИЗАЦИЯ(БИНАРНАЯ)
            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                var newGroups = binFormatter.Deserialize(file) as List<Group>;  //Десереализуем файлик и приводим его к нужному нам типу. *Можно и (List<Group>)binFormatter.Deserialize(file);

                if(newGroups != null)   //проверочка на null и вывод на консоль
                {
                    foreach(var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine();
            //СЕРИАЛИЗАЦИЯ (SOAP)
            var soapFormatter = new SoapFormatter();
            using (var file = new FileStream("groups.soap", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(file, groups.ToArray());   //Сериализуем в файл группы *переводим в массив
            }
            //ДEСЕРИАЛИЗАЦИЯ(SOAP)
            using (var file = new FileStream("groups.soap", FileMode.OpenOrCreate))
            {
                var newGroups = soapFormatter.Deserialize(file) as Group[];  //*SOAP не подерживает списки, приходится приводить к массиву

                if (newGroups != null) 
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }

            Console.WriteLine();

            //СЕРИАЛИЗАЦИЯ (XML)
            var xmlFormatter = new XmlSerializer(typeof(List<Group>));  //Первое отличие, в скобках нжно указать тип к которому будем приводить. * Приватные поля не сериализует.
            using (var file = new FileStream("groups.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(file, groups);   
            }
            //ДEСЕРИАЛИЗАЦИЯ(XML)
            using (var file = new FileStream("groups.xml", FileMode.OpenOrCreate))
            {
                var newGroups = xmlFormatter.Deserialize(file) as List<Group>;  

                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }

            Console.WriteLine();

            //СЕРИАЛИЗАЦИЯ (JSON)
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, students);  //*Отличаются имена для записи
            }
            //ДEСЕРИАЛИЗАЦИЯ(JSON)
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                var newStudents = jsonFormatter.ReadObject(file) as List<Student>;  //*Отличаются имена для чтения

                if (newStudents != null)
                {
                    foreach (var student in newStudents)
                    {
                        Console.WriteLine(student);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
