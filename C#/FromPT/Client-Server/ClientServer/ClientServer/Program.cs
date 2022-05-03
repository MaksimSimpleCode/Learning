using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ClientServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Any, 7000);   //открываем слушателя по порту 7000
            Console.WriteLine("Server started");
            serverSocket.Start();   //сервер стартует

            while(true)
            {
                TcpClient clientSocket = serverSocket.AcceptTcpClient();
                NetworkStream stream = clientSocket.GetStream();//создаем  поток 

                byte[] bytes = new byte[256] ;
                int length = stream.Read(bytes, 0, bytes.Length);
                string request = Encoding.ASCII.GetString(bytes,0,length);
                Console.Write("Got request: " + request);

                string message = "Lenght of your request: "+ request.Length;
                bytes = Encoding.ASCII.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
                stream.Flush();

                Console.WriteLine("Sent message: " + message);
                clientSocket.Close();
            }
            
            serverSocket.Stop();
            Console.WriteLine("Server stopped");
            Console.ReadKey();
        }
    }
}
