using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfo_
{




    class Program
    {
        static void printDirect(DirectoryInfo dir)
        {
            //Создаем объект DirectoryInfo, которому будет обращаться к текущему каталогу
            
            Console.WriteLine("*****"+dir.Name+"*****");
            Console.WriteLine("FullName:{0}", dir.FullName);
            Console.WriteLine("Name:{0}",dir.Name);
            Console.WriteLine("Parent:{0}",dir.Parent);
            Console.WriteLine("Creation:{0}", dir.CreationTime);
            Console.WriteLine("Attributes:{0}",dir.Attributes.ToString());
            Console.WriteLine("Root:{0}",dir.Root);
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\123");
            printDirect(dir);
            DirectoryInfo[] subDirects = dir.GetDirectories();
            Console.WriteLine("Найдено{0} подкаталогов", subDirects.Length);
            foreach(DirectoryInfo d in subDirects)
            {
                printDirect(d);
            }

        }
    }
}
