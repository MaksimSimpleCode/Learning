using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace HeaderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать объект запроса типа WebRequest по указанному URI.
            HttpWebRequest req = (HttpWebRequest)
            WebRequest.Create("http://www.McGraw-Hill.com");
            // Отправить сформированный запрос и получить на него ответ.
            HttpWebResponse resp = (HttpWebResponse)
            req.GetResponse();
            // Получить список имен.
            string[] names = resp.Headers.AllKeys;
            // Отобразить пары "имя-значение" из заголовка.
            Console.WriteLine("{0,-20}(1}\n", "Имя", "Значение");
            foreach (string n in names)
            {
                Console.Write("{0,-20}", n);
                foreach (string v in resp.Headers.GetValues(n))
                    Console.WriteLine(v);
            }
            // Закрыть ответный поток.
            resp.Close();
        }
    }
}
