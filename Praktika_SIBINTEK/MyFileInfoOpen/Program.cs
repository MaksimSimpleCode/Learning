using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFileInfoOpen
{
    /*
     * С помощью метода Filelnfo. Open () можно открывать существующие файлы, а также
создавать новые файлы с более высокой точностью представления, чем обеспечивает
метод Filelnfo. Create (), поскольку Open () обычно принимает несколько параметров
для описания общей структуры файла, с которым будет производиться работа. В результате
вызова Open () возвращается объект FileStream.
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Создать новый файл посредством Filelnfo.Open().
            FileInfo f2 = new FileInfo(@"C:\123\MyFolder2\Test2.txt");
            using (FileStream fs2 = f2.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                // Использовать объект FileStream...
            }



            /*
             * Метод FileOpen. Open () позволяет получить дескриптор файла в гибкой манере,
но класс Filelnfo также предлагает методы OpenRead () и OpenWrite (). Как и можно
было ожидать, указанные методы возвращают подходящим образом сконфигурированный
только для чтения или только для записи объект FileStream без необходимости
в предоставлении значений разных перечислений. Подобно Filelnfo. Create ()
и Filelnfo. Open () методы OpenRead () и OpenWrite () возвращают объект FileStream
*/

            // Получить объект FileStream с правами только для чтения.
            FileInfo f3 = new FileInfo(@"C:\123\MyFolder2\Test3.txt");
            using (FileStream readOnlyStream = f3.OpenRead())
            {
                // Использовать объект FileStream...
            }
            // Теперь получить объект FileStream с правами только для записи.
            FileInfo f4 = new FileInfo(@"CC:\123\MyFolder2\Test4.txt");
            using (FileStream wnteOnlyStream = f4.OpenWrite())
            {
                // Использовать объект FileStream. ..
            }


            /*
             * Еще одним членом типа Filelnfo, связанным с открытием файлов, является
OpenText(). В отличие от Create (), Open(), OpenRead() и OpenWrite() метод
OpenText () возвращает экземпляр типа StreamReader, а не FileStream. Исходя из
того, что на диске С: имеется файл по имени boot, ini, вот как получить доступ к его
содержимому:
*/

            // Получить объект StreamReader.
            FileInfo f5 = new FileInfo(@"C:\boot.ini");
            using (StreamReader sreader = f5.OpenText())
            {
                // Использовать объект StreamReader...

            }

            /*
             * Последними двумя методами, представляющими интерес в данный момент, являются
CreateText () и AppendText (). Оба они возвращают объект StreamWriter:
*/
            FileInfo f6 = new FileInfo(@"C:\Test6.txt");
            using (StreamWriter swnter = f6.CreateText() )
{
                // Использовать объект StreamWriter...
            }
            FileInfo f7 = new FileInfo(@"C:\FinalTest.txt");
            using (StreamWriter swriterAppend = f7.AppendText())
            {
                // Использовать объект StreamWriter...
            }
            }
        }
}
 