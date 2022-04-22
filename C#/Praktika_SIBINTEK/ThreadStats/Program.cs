using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStats   //Возможности получения статистики о потоке
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Статистика потоков*******");

            //Получить имя текущего потока
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";

            //Показать детали обслуживающего домена приложения и контекста.
            Console.WriteLine("Имя текущего домена приложения: {0}", Thread.GetDomain().FriendlyName);   
            Console.WriteLine("Идентификатор текущего контекста приложения: {0}", Thread.CurrentContext.ContextID);   

            //Вывести некоторую статистику о текущем потоке.
            Console.WriteLine("Имя потока: {0}", primaryThread.Name);              
            Console.WriteLine("Запущен ли поток?: {0}", primaryThread.IsAlive);   
            Console.WriteLine("Приоритет потока: {0}", primaryThread.Priority);       
            Console.WriteLine("Состояние потока: {0}", primaryThread.ThreadState);      

            Console.ReadLine();

        }
    }
}
