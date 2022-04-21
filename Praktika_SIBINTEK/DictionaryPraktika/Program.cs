using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPraktika
{
    class Program
    {
        /// <summary>
        /// Не работает, на сайте видимо по другому вызывается метод
        ///Сам метод OptimizeContacts рабочий
        /// </summary>
        /// <returns></returns>
        private static List<string> GetContacts()
        {
            List<string> contacts = new List<string>();
            contacts.Add("Ваня:v@mail.ru");
            contacts.Add("Вася:vasiliy@gmail.com");
            contacts.Add("Ваня:ivan@grozniy.ru");
            contacts.Add("Саша:sasha1995@sasha.ru");
            contacts.Add("Саша:alex@nd.ru");
            contacts.Add("Паша:pavel.egorov@urfu.ru");
            contacts.Add("Юрий:dolg@rukiy.ru");
            contacts.Add("Гена:genadiy.the.best@inbox.ru");
            return contacts;
        }

        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();

            foreach (var e in contacts)
            {
                var parsedContact = e.Split(':');
                var key = e.Substring(0, Math.Min(2, parsedContact[0].Length));

                if(!dictionary.ContainsKey(key))
                {
                    dictionary[key] = new List<string>();
                }

                dictionary[key].Add(e);
            }
            return dictionary;
        }


        static void Main(string[] args)
        {
            var dict = OptimizeContacts(new List<string>());
        }
    }
}
