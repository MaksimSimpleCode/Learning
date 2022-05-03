using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient("localhost", 7000);    //подключаемся к хосту
                Console.WriteLine("Клиент подключился");
               
                NetworkStream stream = client.GetStream();

                string request = "I have an question";
                byte [] bytesWrite = Encoding.ASCII.GetBytes(request);
                stream.Write(bytesWrite, 0, bytesWrite.Length);
                stream.Flush();
                Console.WriteLine("Клиент отправил сообщение на сервер");

                byte[] bytesRead = new byte[256];
                int lenght = stream.Read(bytesRead, 0, bytesRead.Length);
                string answer= Encoding.ASCII.GetString(bytesRead,0, lenght); //разшифровываем то что отправляет сервер
                Console.Write(answer);


                client.Close();
                Console.WriteLine("\nКлиент отключился");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
