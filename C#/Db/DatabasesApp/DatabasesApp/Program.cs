using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace DatabasesApp
{
    class Program
    {
        static  void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-01;Database=adonetdb;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                 connection.Open();
                Console.WriteLine("Подключение открыто");

                // Вывод информации о подключении 
                Console.WriteLine("Свойства подключения:");
                Console.WriteLine($"\tСтрока подключения: {connection.ConnectionString}");
                Console.WriteLine($"\tБаза данных: {connection.Database}");
                Console.WriteLine($"\tСервер: {connection.DataSource}");
                Console.WriteLine($"\tВерсия сервера: {connection.ServerVersion}");
                Console.WriteLine($"\tСостояние: {connection.State}");
                Console.WriteLine($"\tWorkstationld: {connection.WorkstationId}");

            }
            Console.WriteLine("Подключение закрыто...");
            Console.WriteLine("Программа завершила работу.");
            Console.Read();
        }
    }
    
}
