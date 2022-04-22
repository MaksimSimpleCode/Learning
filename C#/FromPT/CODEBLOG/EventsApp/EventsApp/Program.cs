using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Небольшое отступление от темы
            Object[] objects = new Object[]{ 1,"15","t",3,5,"gfd",3.15};

            string errorMsg = String.Empty;
            foreach(var obj in objects)
            {
                try
                {
                    Console.WriteLine((int)obj + 100);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Символ {obj} не прошел с ошибкой: {ex.Message}");
                }
                
            }
            Console.WriteLine("Отработано!");

            Dictionary<string, decimal> book = new Dictionary<string, decimal>();
            book.Add("Максим", 600000);
            book.Add("Владимир", 500000);

            decimal value = 600000;
            bool test = book.TryGetValue("Максим",out value);
            Console.WriteLine(test);

            #endregion

            var mailManager = new MailManager();
            mailManager.NewMail += MailManagerNewMail;

 

            Console.Write("Введите ваше имя: ");
            var sender = Console.ReadLine();
            
            Console.Write("С кем вы хотите связаться: ");
            var target = Console.ReadLine(); 
            
            Console.Write("Введите текст сообщения: ");
            var message = Console.ReadLine();

            mailManager.SimulateNewMail(sender, target, message);

        }

        private static void MailManagerNewMail(object sender, NewEmailEventArgs e)
        {
            var sms = new SMS();
            sms.Send(e.Subject);

            var printer = new Printer();
            printer.Print($"Сообщение от {e.From} для {e.To}.\r\n {e.Subject}");
        }
    }
}
