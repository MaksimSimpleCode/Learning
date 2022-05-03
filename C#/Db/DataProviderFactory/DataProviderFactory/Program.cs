using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using static System.Console;
using System.Configuration;

namespace DataProviderFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***** Data Provider Factories*****");
            //Получить строку подключения из поставщик из файла *.config.
            string dataProvider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            //Получить фабрику поставщиков 
            DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);

            //Получить объект подключения
            using(DbConnection connection = factory.CreateConnection())
            {
                if(connection == null)
                {
                    ShowError("Connection");
                    return;
                }
                WriteLine($"Your connection object is a: {connection.GetType().Name}");
                connection.ConnectionString = connectionString;
                connection.Open();

                //Создать объект команды
                DbCommand command = factory.CreateCommand();
                if(command == null)
                {
                    ShowError("Command");
                    return;
                }
                WriteLine($"Your command object is a: {command.GetType().Name}");
                command.Connection = connection;
                command.CommandText = "Select * From Inventory";
                //Вывести данные с помощью объекта чтения данных
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    WriteLine($"Your data Reader object is a: {dataReader.GetType().Name}");
                    WriteLine("\n****** Current Inventory******");
                    while (dataReader.Read())
                        WriteLine($"-> Car #{dataReader["CarId"]} is a {dataReader["Make"]}.");
                }
            }
            ReadLine();
        }
        private static void ShowError(string objectName)
        {
            WriteLine($"There was an issue creating the {objectName}");
            //Возникла проблема с созданием объекта 
            ReadLine(); 
        }
    }
}
