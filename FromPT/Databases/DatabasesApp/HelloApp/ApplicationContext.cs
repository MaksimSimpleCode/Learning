using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    //Класс для взаимодейсвтия с БД с помощью EF
    public class ApplicationContext : DbContext
    {

        public DbSet<User> Users {get;set;} // первый способ добавить модель в БД

        public string connectionString;

        //public ApplicationContext(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //   // Database.EnsureDeleted();   //Гарантирует удаление БД в конструкторе
        //   // Database.EnsureCreated();   //Гарантирует создание БД в конструкторе и недостающих полей
        //}

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) //Перегрузка конструктора
        {
 
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //var connectionString = "Server=DESKTOP-01;Database=TestDB;Trusted_Connection=True;";
        //    optionsBuilder.UseSqlServer(connectionString);
        //   // optionsBuilder.LogTo(Console.WriteLine);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // использование Fluent API
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>(); //Второй способ после DbSet<> добавить модель в базу
           // modelBuilder.Ignore<Company>(); //Один из способов отменить таблицу
        }
    }
}
