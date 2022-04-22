using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ресурс (URL): ");
            var site= Console.ReadLine();

            string sourceCode = null;
            // Создать объект запроса
            WebRequest request = WebRequest.Create(site);

            // Получить ответ с сервера
            WebResponse response = request.GetResponse();

            // Получаем поток данных из ответа
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                // Выводим исходный код страницы
                string line;
                while ((line = stream.ReadLine()) != null)
                    sourceCode += line + "\n";
            }

            // Получаем некоторые данные о сервере
            string messageServer = "Целевой URL: \t" + request.RequestUri + "\nМетод запроса: \t" + request.Method +
                 "\nТип полученных данных: \t" + response.ContentType + "\nДлина ответа: \t" + response.ContentLength + "\nЗаголовки";

            // Получаем заголовки, используем LINQ
            WebHeaderCollection whc = response.Headers;
            var headers = Enumerable.Range(0, whc.Count)
                                    .Select(p =>
                                    {
                                        return new
                                        {
                                            Key = whc.GetKey(p),
                                            Names = whc.GetValues(p)
                                        };
                                    });

            foreach (var item in headers)
            {
                messageServer += "\n  " + item.Key + ":";
                foreach (var n in item.Names)
                    messageServer += "\t" + n;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Исходный код страницы: \n{sourceCode}");
            Console.ResetColor();

            Console.WriteLine(messageServer);
            Console.ReadLine();
        }
    }
}
