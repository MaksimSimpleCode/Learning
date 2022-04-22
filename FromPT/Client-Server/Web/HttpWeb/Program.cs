using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            string site = "http://www.professorweb.ru";

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(site);   //Создаем запрос к ресурсу
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();  //Получаем ответ от ресурса

            using (StreamReader stream = new StreamReader(resp.GetResponseStream(), Encoding.UTF8))
            {
                Console.WriteLine(stream.ReadToEnd());
            }


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Заголовки: ");
            foreach (string header in resp.Headers)
            {
                Console.WriteLine("{0}:  {1}\n", header, resp.Headers[header]);
            }


                Console.ReadLine();
        }
    }
}
