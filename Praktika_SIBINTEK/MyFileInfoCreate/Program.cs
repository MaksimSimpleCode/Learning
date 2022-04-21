using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MyFileInfoCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать новый файл на диске C
            FileInfo f = new FileInfo(@"C:\123\MyFolder2\Test.dat");
            FileStream fs = f.Create();

            //Использовать объект FileStream....

            //Закрыть файловый поток
            fs.Close();
        }
    }
}
