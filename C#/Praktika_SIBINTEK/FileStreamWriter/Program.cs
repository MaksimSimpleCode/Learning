using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            FileStream fout;

            string s;
            FileStream fin;

            //Открыть сначала поток файлового ввода-вывода.
            try
            {
                fout = new FileStream("testStreamWriter.txt", FileMode.Create);
            }
            catch(IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла:\n" + exc.Message);
                return;
            }
            //Заключить поток файлового ввода-вывода в оболочку класса StreamWriter.
            StreamWriter fstr_out = new StreamWriter(fout);

            try
            {
                Console.WriteLine("Введите текст, а по окончании- 'стоп'.");
                do
                {
                    Console.Write(": ");
                    str = Console.ReadLine();

                    if (str != "стоп")
                    {
                        str = str + "\r\n"; //Добавить новую строку
                        fstr_out.Write(str);
                    }

                } while (str != "стоп");
            }catch(IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally { fstr_out.Close(); }

            Console.WriteLine("Теперь прочитаем содержимое файла");
            try
            {
                fin = new FileStream("testStreamWriter.txt", FileMode.Open);
            }catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
                return;
            }

            StreamReader fstr_in = new StreamReader(fin);
            try
            {
                while ((s = fstr_in.ReadLine()) != null) ;
                Console.WriteLine(s);
            }
            catch(IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally
            {
                fstr_in.Close();
            }
        }
    }
}
