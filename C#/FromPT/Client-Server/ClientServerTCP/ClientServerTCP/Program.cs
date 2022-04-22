using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketTcpServer
{
    //Сервер на сокетах Tcp 
    class Program
    {
        static int port = 8005; //порт для приема входящих запросов
        static void Main(string[] args)
        {
            //Получаем адреса для запуска сокета
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

            //Создаем сокет
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                //связываем сокет с локальной точкой, по которой будем принимать данные
                listenSocket.Bind(ipPoint);

                //начинаем прослушивание
                listenSocket.Listen(10);

                Console.WriteLine("Сервер запущен. Ожидание подключений...");

                while (true)
                {
                    Socket handler = listenSocket.Accept();
                    //Получаем сообщение
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;//количество полученных байтов
                    byte[] data = new byte[256]; //буфер для получаемых данных

                    do
                    {
                        bytes = handler.Receive(data);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (handler.Available > 0);

                    Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());

                    //Отправляем ответ
                    string message = "Ваше сообщение доставлено";
                    data = Encoding.Unicode.GetBytes(message);
                    handler.Send(data);
                    //Закрываем сокет
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
