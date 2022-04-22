using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyDirectoryWatcher
{
    /*
     * Показанный ниже проект консольного приложения
(MyDirectoryWatcher) наблюдает за файлами * .txt в каталоге MyFolder и выводит
на консоль сообщения, когда происходит их создание, удаление, модификация и
переименование:
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****The Amazing File Watcher App * ****\n");
            // Установить путь к каталогу, за которым нужно наблюдать.
            FileSystemWatcher watcher = new FileSystemWatcher();
            try
            {
                watcher.Path = @"C:\123\MyFolder2";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            // Указать цели наблюдения.
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            // Следить только за текстовыми файлами.
            watcher.Filter = "*.txt";
            // Добавить обработчики событии.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            // Начать наблюдение за каталогом.
            watcher.EnableRaisingEvents = true;
            // Ожидать от пользователя команду завершения программы.
            Console.WriteLine(@"Press 'q' to quit app.");
            while (Console.Read() != 'q') ;
        
        }
        static void OnChanged(object source, FileSystemEventArgs e)
        {
            // Сообщить о действии изменения, создания или удаления файла.
            Console.WriteLine("File : {0} {1}!", e.FullPath, e.ChangeType);
        }
        static void OnRenamed(object source, RenamedEventArgs e)
        {
            // Сообщить о действии переименования файла.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
    }
}
