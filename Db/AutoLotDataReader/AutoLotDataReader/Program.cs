using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Data Readers *****");
            //Создать и открыть подключение
            using(SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = (localdb)\mssqllocaldb;Integrated Security = true;Initial Catalog=AutoLot";
                connection.Open();

                //Создать объект команды SQL
                string sql = "Select * From Inventory";
                SqlCommand myCommand = new SqlCommand(sql, connection);

                //Получить объект чтения данных с помощью ExecuteReader().
                using(SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    //Пройти в цикле по результатам
                    while (myDataReader.Read())
                    Console.WriteLine($"-> Make: {myDataReader["Make"]}, PetName: {myDataReader["PetName"]}, Color: {myDataReader["Color"]}.");
                }
            }
            Console.ReadLine();
        }
    }
}
