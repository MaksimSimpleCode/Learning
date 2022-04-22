using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Redirection   //Переадресация
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter log_out = null;
            try
            {
                log_out = new StreamWriter("logfile.txt");

                //Переадресовать стандартный вывод в файл logfile.txt
                Console.SetOut(log_out);
                Console.WriteLine("Это начало файла журнала регистрации.");

                for (int i = 20; i < 50; i++)
                    Console.WriteLine(i);
                Console.WriteLine("Это конец журнала регистрации.");
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally { if (log_out != null) log_out.Close(); }
        }
    }
}
