using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (FileStream stream = new FileStream(@"D:\StreamTest.txt", FileMode.OpenOrCreate)) 
            {
                // выделяем массив для считывания данных из файла
                byte[] buffer = new byte[stream.Length];
                // считываем данные
                await stream.ReadAsync(buffer, 0, buffer.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.UTF8.GetString(buffer);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }
               
            
        }
    }
}
