using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SimpleFileIo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple I/O with the File Type *****\n");

        string[] myTasks = {"Fix bathroom sink", "Call Dave","Call Mom and Dad", "Play Xbox One"};
            
            // Записать все данные в файл на диске С: 
        File.WriteAllLines(@"C:\123\MyFolder2\test.txt", myTasks);
            // Прочитать все данные и вывести на консоль.
            foreach (string task in File.ReadAllLines(@"C:\123\MyFolder2\test.txt"))
            {
                Console.WriteLine("TODO: {0}", task);
            }
            Console.ReadLine();
        }
    }
}
