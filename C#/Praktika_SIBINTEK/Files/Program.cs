using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream myFile = null;
            try
            {
                //Открыть входной файл
                myFile = new FileStream("Test.txt", FileMode.CreateNew);
                //Записать весь английский алфавит в файл
                for (char c = 'A'; c <= 'Z'; c++)
                    myFile.WriteByte((byte)c);
            }
            catch(IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally
            {
                if (myFile != null) myFile.Close();
            }
            
        }
    }
}
