using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-01;Database=adonetdb;Trusted_Connection=True;";
            //string request = "CREATE DATABASE adonetdb";
            //string request = "CREATE TABLE Users (Id INT PRIMARY KEY IDENTITY, Age INT NOT NULL, Name NVARCHAR(100) NOT NULL)";
            string request = "INSERT INTO Users (Name, Age) VALUES ('Tom', 36)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();
            }
            Console.WriteLine("Подключение закрыто...");
            Console.WriteLine("Программа завершила работу.");
            Console.Read();
        }
    }
}
