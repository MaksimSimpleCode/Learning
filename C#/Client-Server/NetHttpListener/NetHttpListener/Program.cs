using System;
using System.Net;
using System.IO;

namespace NetHttpListener
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener listener = new HttpListener();
            //Установка адресов прослушки
            listener.Prefixes.Add("http://localhost:8888/connection/");
            listener.Start();
            Console.WriteLine("Ожидание подключений...");

            int test = 0;
            while (test<=5)
            {
               

                //Метод GetContext блокирует текущий поток, ожидая получение запроса 
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                //Получаем объект ответа 
                HttpListenerResponse response = context.Response;
                //Создаем ответ в виде кода html
                string responseStr = $"<html><head><meta charset='utf8'></head><body>Привет мир! {test}</body></html>";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseStr);
                // получаем поток ответа и пишем в него ответ
                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                test++;
                //закрываем поток
                output.Close();
                
            }

            // останавливаем прослушивание подключений
            listener.Stop();
            Console.WriteLine("Обработка подключений завершена");
            Console.Read();
        }
    }
}
