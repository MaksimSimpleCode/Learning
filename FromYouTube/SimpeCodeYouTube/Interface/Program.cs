using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /*
     * Интерфейсы и полиморфизм
     */

    interface IDataProvider 
    {
        string GetData();
    }
    
    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }

    class ConsoleDataProcessor : IDataProcessor   //Реализуем интерфейс
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из БД";
        }
    }
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из файла";
        }
    }
    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из API";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());
        }
    }
}
