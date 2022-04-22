using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncWithDirectoryType();
        }

        static void  FuncWithDirectoryType()
        {
            //Вывести список всех логических устройств на текущем компьютере
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Вот ваши устройства: ");
            foreach (string s in drives)
                Console.WriteLine("--> {0}", s);

            //Удалить ранее созданные подкаталоги
            Console.WriteLine(" Нажмите Enter чтобы удалить каталоги");
            Console.ReadLine();
            try
            {
                Directory.Delete(@"C:\123\MyFolder");
                //Второй параметр указывает, нужно ли удалять внутренние подкаталоги
                Directory.Delete(@"C:\123\MyFolder2\Data\1234", true);

            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
