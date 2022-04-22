using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketTcpClient
{
    class Program
    {
        // адрес и порт сервера, к которому будем подключаться
        static int port = 8005; // порт сервера
        static string address = "127.0.0.1"; // адрес сервера
        static void Main(string[] args)
        {
            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //Подключаемся к удаленному хосту 
                socket.Connect(ipPoint);
                Console.WriteLine("Введите сообщение: ");
                string message = Console.ReadLine();
                byte[] data = Encoding.Unicode.GetBytes(message);
                socket.Send(data);

                //Получаем ответ 
                data = new byte[256]; //буфер для ответа
                StringBuilder builder = new StringBuilder();
                int bytes = 0; //Количество полученных байт

                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);
                Console.WriteLine("Ответ от сервера: " + builder.ToString());

                //Закрываем сокет
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
