using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectDemo
{
    class ContactInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ContactInfo(string n, string a, string p)
        {
            Name = n;
            Email = a;
            Phone = p;
        }
    }
    class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public EmailAddress(string n, string a)
        {
            Name = n;
            Address = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ContactInfo[] contacts = {
            new ContactInfo("Герберт", "Herb@HerbSchildt.com", "555-1010"),
            new ContactInfo("Tom", "Tom@HerbSchildt.com", "555-1101"),
            new ContactInfo("Capa", "Sara@HerbSchildt.com", "555-0110")
                };
            // Сформировать запрос на получение списка объектов типа EmailAddress.
            var emailList = from entry in contacts
                            select new EmailAddress(entry.Name, entry.Email);
            Console.WriteLine("Список адресов электронной почты:");
            // Выполнить запрос и вывести его результаты.
            foreach (EmailAddress e in emailList)
                Console.WriteLine(" {0}: {1}", e.Name,e.Address);

            /*Тут вся фишка в том что мы сделали массив, передали массив запросу и запрос ВО ВРЕМЯ ВЫПОЛНЕНИЯ
             * создал объекты типа EmailAddress.
             * То есть условие в select создает нам объекты из массива прямо во время выполнения программы.
             */

            //То есть селект не просто выводит результат, а может менять тип данных, значение, создавать объекты и т.д
        }
    }
}
