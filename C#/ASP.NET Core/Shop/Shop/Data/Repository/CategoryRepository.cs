using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDbContext appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => appDbContext.Category;
    }
}
