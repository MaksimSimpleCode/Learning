using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Будет использоваться поставщик SQL Server; однако
// для обеспечения более высокой гибкости разрешено
// также применять паттерн фабрики поставщиков ADO.NET.
using System.Data;
using System.Data.SqlClient;

using AutoLotDAL.Models;

namespace AutoLotDAL.DataOperations
{
   
    public class InventoryDAL
    {
        private readonly string _connectionString;
        private SqlConnection _sqlConnection = null;
        public InventoryDAL(): this(@"Data Source = (localdb)\mssqllocaldb;Integrated Security = true; Initial Catalog = AutoLot")
        {

        }
        public InventoryDAL(string connectionString) => _connectionString = connectionString;

        private void OpenConnection()
        {
            _sqlConnection = new SqlConnection { ConnectionString = _connectionString };
            _sqlConnection.Open();
        }

        private void CloseConnection()
        {
           if(_sqlConnection?.State!= ConnectionState.Closed)
            {
                _sqlConnection.Close();
            }
        }

        public List <Car> GetAllInventory()
        {
            OpenConnection();
            //Здесь будут храниться записи.
            List<Car> inventory = new List<Car>();

            //Подготовить объект команды.
            string sql = "Select * From Inventory";
            using(SqlCommand command = new SqlCommand (sql,_sqlConnection ))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader  dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while(dataReader.Read())
                {
                    inventory.Add(new Car
                    {
                        CarId = (int)dataReader["CarId"],
                        Color = (string)dataReader["Color"],
                        Make = (string)dataReader["Make"],
                        PetName = (string)dataReader["PetName"]
                    });   
                }
                dataReader.Close();
            }
            return inventory;
        }


        public Car GetCar(int id)
        {
            OpenConnection();
            Car car = null;
            string sql = $"Select * from Inventory where CarId = {id}";
            using (SqlCommand command = new SqlCommand(sql,_sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while(dataReader.Read())
                {
                    car = new Car
                    {
                        CarId = (int)dataReader["CarId"],
                        Color = (string)dataReader["Color"],
                        Make = (string)dataReader["Make"],
                        PetName = (string)dataReader["PetName"]
                    };
                }
                dataReader.Close();
            }
            return car;
        }

        public void InsertAuto (string color, string make, string petName)
        {
            OpenConnection();
            //Сформировать и выполнить оператор SQL
            string sql = $"Insert Into Inventory (Make,Color,PetName) Values ('{make}','{color}','{petName}')";
            //Выполнить используя наше подключение 
            using (SqlCommand command = new SqlCommand(sql,_sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void InsertAuto (Car car)
        {
            OpenConnection();
            //Сформировать и выполнить оператор SQL
            string sql = "Insert into Inventory (Make,Color,PetName) Values" +$"('{car.Make}','{car.Color}','{car.PetName}')";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void DeleteCar(int id)
        {
            OpenConnection();
            //Получить идентификатор автомобиля, подлежащего удалению, и удалить запись о нем
            string sql = $"Delete from Inventory where CardId = '{id}'";
            using(SqlCommand command = new SqlCommand(sql,_sqlConnection))
            {
                try
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    Exception error = new Exception("Ssory! That car is on order!", ex);
                    //Этот автомобиль заказан!
                    throw error;
                }
            }
            CloseConnection();
        }

        public void UpdateInventoryCarPetName(int id, string newPetName)
        {
            OpenConnection();
            //Получить идентификатор автомобиля для модицикации дружественного имени.
            string sql = $"Update Inventory Set PetName = '{newPetName}' Where CardId = '{id}'";
            using(SqlCommand command = new SqlCommand(sql,_sqlConnection))
            {
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public string LookUpPetName(int carId)
        {
            OpenConnection();
            string carPetName;

            //Установить имя хранимой процедуры
            using (SqlCommand command = new SqlCommand("GetPetName",_sqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                //Входной параметр
                SqlParameter param = new SqlParameter
                {
                    ParameterName = "carId",
                    SqlDbType = SqlDbType.Int,
                    Value = carId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(param);
                //Выходной параметр
                param = new SqlParameter
                {
                    ParameterName = "@petName",
                    SqlDbType = SqlDbType.Char,
                    Size = 10,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(param);
                //Выполнить хранимую процедуру
                command.ExecuteNonQuery();

                //Возвратить выходной параметр
                carPetName = (string)command.Parameters["@petName"].Value;
                CloseConnection();
            }
            return carPetName;
        }
    }
}
