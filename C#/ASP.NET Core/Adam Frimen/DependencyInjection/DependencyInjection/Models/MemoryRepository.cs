using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class MemoryRepository : IRepository
    {
        private Dictionary<string, Product> products;
        private IModelStorage storage;
        private string guid = System.Guid.NewGuid().ToString();
        public MemoryRepository(IModelStorage modelstore)
        {
            storage = modelstore;
            new List<Product> {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M }
                }.ForEach(p => AddProduct(p));
        }

        public Product this[string name] => storage[name];

        public IEnumerable<Product> Products => storage.Items;

        public void AddProduct(Product product)
        {
            storage[product.Name] = product;
        }

        public void DeleteProduct(Product product)
        {
            storage.Removeitem(product.Name);
        }
        public override string ToString()
        {
            return guid;
        }
    }
}
