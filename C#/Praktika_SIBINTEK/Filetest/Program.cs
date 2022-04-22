using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filetest  //Запись данных в файл
{
    class Program
    {
        static void Notes()
        {
            string notes;
            string time = DateTime.Now.ToString();  //можно вместо стринг использовать DateTime тогда не нужно будет делать привидение типов(скорее всего)

            Console.WriteLine("Введите заметку: ");
            notes = Console.ReadLine();

            using (var sw = new StreamWriter("Notes.txt", true,Encoding.UTF8))  //Создаем объект записи
            {
                sw.WriteLine("Время записи: "+ time);
                sw.WriteLine("Запись: " + notes+"\n");
            }
        }

        static void TakeNotes()
        {
            using (var sr = new StreamReader("Notes.txt"))  //Создаем объект чтения
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*****Читаю все записи******");
                Console.WriteLine( sr.ReadToEnd());
            }
        }
        static void Main(string[] args)
        {

            Notes();
           
            TakeNotes();

            Notes();

            TakeNotes();

            Console.ReadLine();
            
             
        }
    }
}
