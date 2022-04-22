using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
   public class SMS
    {
        public void Send(string message)
        {
            Console.WriteLine($"Отправляем SMS сообщение: \r\n{message}\r\n");
        }
    }
}
