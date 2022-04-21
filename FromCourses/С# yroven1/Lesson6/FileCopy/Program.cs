using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fileln = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                FileStream fileOut = new FileStream("newData.txt", FileMode.Create, FileAccess.Write);
                int i;
                while ((i = fileln.ReadByte()) != -1)
                {
                    //запись очередного байта в поток, связаный с файлом fileOut
                    fileOut.WriteByte((byte)i);
                }
                fileln.Close();
                fileOut.Close();
            }
            catch (Exception exc)

            {
                Console.WriteLine(exc.Message);
            }
            Console.WriteLine("Файл успешно скопирован");
        }
    }
}
