using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
   public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Position { get; set; }   // Новое свойство - должность пользователя

        //Навигационное свойство
        public Company? Company { get; set; }   //Так как User присутсвует в dbContext то таблица Company создастя как связанная
    }

   // [NotMapped] один из способов не использовать модель в БД
    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
    public class Country    //Так как в dbContext нет DbSet<Countru> то в бд он не будет создан и как то воздействован
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
