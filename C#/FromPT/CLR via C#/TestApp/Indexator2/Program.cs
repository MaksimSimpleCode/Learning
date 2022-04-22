using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexator2
{
    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User();
            // устанавливаем значения
            tom["name"] = "Tom";
            tom["email"] = "tom@gmail.ru";
            tom["phone"] = "+1234556767";

            // получаем значение
            Console.WriteLine(tom["phone"]); // Tom
        }
    }
    class User
    {
        string name = "";
        string email = "";
        string phone = "";
        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "name": return name;
                    case "email": return email;
                    case "phone": return phone;
                    default: throw new Exception("Unknown Property Name");
                }
            }
            set
            {
                switch (propname)
                {
                    case "name":
                        name = value;
                        break;
                    case "email":
                        email = value;
                        break;
                    case "phone":
                        phone = value;
                        break;
                }
            }
        }
    }
}
