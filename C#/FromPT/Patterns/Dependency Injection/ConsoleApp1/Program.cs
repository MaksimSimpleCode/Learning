using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var providerOne = new SqlDb(); 
            var providerTwo = new NoSqlDb();
            UserController uc = new UserController(providerOne);  //используем 2 провайдер

            uc.GetUsers();
        }
    }
    interface IDbContext
    {
        User[] GetUsers();
    }
    public class SqlDb : IDbContext
    {
        public User[] GetUsers()
        {
            return new User[] { new User { Name = "Maks" }, new User { Name = "Valera" } };
        }
    }
    public class NoSqlDb : IDbContext
    {
        public User[] GetUsers()
        {
            return new User[] { new User { Name = "Jon" }, new User { Name = "Lex" } };
        }
    }
    class UserController
    {
        private IDbContext _db;
        public UserController(IDbContext db)
        {
            _db = db;
        }
        public void GetUsers()
        {
            var users = _db.GetUsers();
            foreach (var us in users)
                Console.WriteLine(us.Name);
        }
    }
    public class User
    {
        public string Name { get; set; }
    }
}
