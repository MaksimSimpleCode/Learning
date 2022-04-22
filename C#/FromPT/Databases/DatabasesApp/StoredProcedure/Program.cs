using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedure
{
    class Program
    {
       static string connectionString = "Server=DESKTOP-01;Database=adonetdb;Trusted_Connection=True;";
        static async Task  Main(string[] args)
        {


            //string proc1 = @"CREATE PROCEDURE [dbo].[sp_InsertUser]
            //                    @name nvarchar(50),
            //                    @age int
            //                AS
            //                    INSERT INTO Users (Name, Age)
            //                    VALUES (@name, @age)

            //                    SELECT SCOPE_IDENTITY()
            //                GO";

            //string proc2 = @"CREATE PROCEDURE [dbo].[sp_GetUsers]
            //                    AS
            //                        SELECT * FROM Users 
            //                    GO";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    SqlCommand command = new SqlCommand(proc1, connection);

            //    // добавляем первую процедуру
            //    command.ExecuteNonQuery();

            //    // добавляем вторую процедуру
            //    command.CommandText = proc2;
            //    command.ExecuteNonQuery();
            //    Console.WriteLine("Хранимые процедуры добавлены в базу данных.");

            //    Console.Read();
            //}

            Console.Write("Введите имя пользователя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст пользователя: ");
            int age = Int32.Parse(Console.ReadLine());

            await AddUserAsync(name, age);

            Console.WriteLine();

            await GetUsersAsync();

            Console.Read();
        }
        private static async Task AddUserAsync(string name, int age)
        {
            // название процедуры
            string sqlExpression = "sp_InsertUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = name
                };
                // добавляем параметр
                command.Parameters.Add(nameParam);
                // параметр для ввода возраста
                SqlParameter ageParam = new SqlParameter
                {
                    ParameterName = "@age",
                    Value = age
                };
                command.Parameters.Add(ageParam);

                // выполняем процедуру
                var id = await command.ExecuteScalarAsync();
                // если нам не надо возвращать id
                //var id = await command.ExecuteNonQueryAsync();

                Console.WriteLine($"Id добавленного объекта: {id}");
            }
        }

        // вывод всех пользователей
        private static async Task GetUsersAsync()
        {
            // название процедуры
            string sqlExpression = "sp_GetUsers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        Console.WriteLine($"{reader.GetName(0)}\t{reader.GetName(2)}\t{reader.GetName(1)}");

                        while (await reader.ReadAsync())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(2);
                            int age = reader.GetInt32(1);
                            Console.WriteLine($"{id} \t{name} \t{age}");
                        }
                    }
                }
            }
        }
    }
}
