using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationShipsBetweenModels
{
    class Modles
    {
    }

    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; } // название компании

        public List<User> Users { get; set; } = new();
    }

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int CompanyId { get; set; }      // внешний ключ
        public Company? Company { get; set; }    // навигационное свойство
    }
}
