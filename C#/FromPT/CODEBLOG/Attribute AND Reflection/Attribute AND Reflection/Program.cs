using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_AND_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("Hello.png")
            {
                Path = @"D:\C#\Hello.png"
            };

            var type = typeof(Photo);   //получаем метаданные 
            var attributes = type.GetCustomAttributes(false);   //получаем массив всех атрибутов классов атрибутов
            foreach(var attribute in attributes) //перебираем атрибуты
            {
                Console.WriteLine(attribute);
            }

            var properties = type.GetProperties();
            foreach(var prop in properties)
            {
                var attrs = prop.GetCustomAttributes(false);

               if(attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType + " " + prop.Name + " " + prop.Attributes);
                }



                foreach (var a in attrs)
                {
                    Console.WriteLine(a);
                }
            }

            Console.ReadLine();
        }
    }
}
