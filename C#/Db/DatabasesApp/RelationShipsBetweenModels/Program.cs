using System;
using System.Linq;

namespace RelationShipsBetweenModels
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = "Server = DESKTOP-01; Database = RelationShipsDB; Trusted_Connection = True; ";

            //Установка главной сущности по навигационному свойству зависимой сущности
            using (ApplicationContext db = new ApplicationContext(connectionstring))
            {
                Company company1 = new Company { Name = "Google" };
                Company company2 = new Company { Name = "Microsoft" };
                User user1 = new User { Name = "Tom", Company = company1 };
                User user2 = new User { Name = "Bob", Company = company2 };
                User user3 = new User { Name = "Sam", Company = company2 };

                db.Companies.AddRange(company1, company2);  // добавление компаний
                db.Users.AddRange(user1, user2, user3);     // добавление пользователей
                db.SaveChanges();

                foreach (var user in db.Users.ToList())
                {
                    Console.WriteLine($"{user.Name} работает в {user.Company?.Name}");
                }
            }

            //Установка главной сущности по свойству-внешнему ключу зависимой сущности
            using (ApplicationContext db = new ApplicationContext(connectionstring))
            {
                Company company1 = new Company { Name = "Google" };
                Company company2 = new Company { Name = "Microsoft" };
                db.Companies.AddRange(company1, company2);  // добавление компаний
                db.SaveChanges();

                User user1 = new User { Name = "Tom", CompanyId = company1.Id };
                User user2 = new User { Name = "Bob", CompanyId = company1.Id };
                User user3 = new User { Name = "Sam", CompanyId = company2.Id };

                db.Users.AddRange(user1, user2, user3);     // добавление пользователей
                db.SaveChanges();

                foreach (var user in db.Users.ToList())
                {
                    Console.WriteLine($"{user.Name} работает в {user.Company?.Name}");
                }
            }

            //Установка зависимой сущности через навигационное свойство главной сущности
            using (ApplicationContext db = new ApplicationContext(connectionstring))
            {
                User user1 = new User { Name = "Tom" };
                User user2 = new User { Name = "Bob" };
                User user3 = new User { Name = "Sam" };

                Company company1 = new Company { Name = "Google", Users = { user1, user2 } };
                Company company2 = new Company { Name = "Microsoft", Users = { user3 } };

                db.Companies.AddRange(company1, company2);  // добавление компаний
                db.Users.AddRange(user1, user2, user3);     // добавление пользователей
                db.SaveChanges();

                foreach (var user in db.Users.ToList())
                {
                    Console.WriteLine($"{user.Name} работает в {user.Company?.Name}");
                }

                //Здесь демонстрируется каскадное удаление- при удалении главной сущности(компания)- удаляется и зависимая(Юзер)
                //db.Companies.Remove(company2);
                //db.SaveChanges();
                //foreach (var user in db.Users.ToList())
                //{
                //    Console.WriteLine($"{user.Name} работает в {user.Company?.Name}");
                //}
            }
        }
    }
}
