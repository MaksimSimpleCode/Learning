using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetSampleProducts();
            foreach (Product product in products.OrderBy(p => p.Name).Where(p => p.Price > 6))     //Сортировка по имени с помощью метода разширений а так же по цене
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("________________");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }

    public class Product
    {
        readonly string name;
        public string Name { get { return name; } }

        readonly decimal? price;
        public decimal? Price { get { return price; }}
        public Product(string name, decimal? price = null)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product(name: "Сланцы", price: 9.99m),
                new Product(name: "Адиколон", price: 3.32m),
                new Product(name: "Лодка", price: 23.19m),
                new Product(name: "Майка", price: 6.32m),
                new Product(name: "Бант", price: 5.78m),
                new Product(name: "Линейка")
            };
        }
        public override string ToString()
        {
            return string.Format($"{name} : {price}");
        }

    }
}
