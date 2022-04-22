using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyDirectoryInfo
{   //Изучаем DirectoryInfo. Получаем информацию о каталоге
    //DirectoryInfo и Directory отличаются тем что DirectoryInfo работает с экземпляром а Directory статический класс.
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("***** DirectoryInfo Program *****\n");
            ShowWindowsDirectoryInfo();

            DisplayImageFiles();
            Console.ReadLine();
        }

        static void ShowWindowsDirectoryInfo()  //Демонстрация свойств работы с каталогом
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\123");
            Console.WriteLine("***** DirectoryInfo *****");
            Console.WriteLine("Полное имя: {0}", dir.FullName);
            Console.WriteLine("Имя: {0}", dir.Name); // имя каталога
            Console.WriteLine("Родитель: {0}", dir.Parent); // родительский каталог
            Console.WriteLine("Время создания: {0}", dir.CreationTime); // время создания
            Console.WriteLine("Атрибуты: {0}", dir.Attributes); // атрибуты
            Console.WriteLine("Корень: {0}",dir.Root); // корневой каталог
            Console.WriteLine("**************************\n");

        }

        static void DisplayImageFiles() //Ищем в категории файл с нужным расширением, затем выводим информацию о каждом найденном файле
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\123");
            //Получить все файлы с разширением * .jpg.
            FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

            
            //Вывести информацию о каждом файле.
            foreach(FileInfo f in imageFiles)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("Имя файла: {0}", f.Name);    //Имя файла
                Console.WriteLine("Размер файла: {0}", f.Length); // размер
                Console.WriteLine("Время создания: {0}", f.CreationTime); // время создания
                Console.WriteLine("Атрибуты: {0}", f.Attributes); // атрибуты
                Console.WriteLine("***************************\n");
            }
            //Сколько найдено? 
            Console.WriteLine("Файлов найдено: {0} *.jpg files\n", imageFiles.Length);
        }
    }
}
