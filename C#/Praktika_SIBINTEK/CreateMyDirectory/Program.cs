using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateMyDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание каталога и подкаталога");
            ModifyAppDirectory();
        }

        static void ModifyAppDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\123");
            // Создать \MyFolder в каталоге приложения.
            dir.CreateSubdirectory("MyFolder");
            // Создать \MyFolder2\Data в каталоге приложения.
            dir.CreateSubdirectory(@"MyFolder2\Data\1234");
            
            //dir.Delete() думаю понятно
        }
        
    }
}
