using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
  public  class Printer
    {
        public void Print(string text)
        {
            Console.WriteLine($"Печатаем  сообщение на принтере: \r\n{text}\r\n");
        }
    }
}
