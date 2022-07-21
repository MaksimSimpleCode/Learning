using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationShipsBetweenModels
{
  public  class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;
        string connectionString;
        public ApplicationContext(string connectionString)
        {
            this.connectionString = connectionString;
            Database.EnsureDeleted();
            Console.WriteLine("База данных удалена");
            Database.EnsureCreated();
            Console.WriteLine("База данных создана\n");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
