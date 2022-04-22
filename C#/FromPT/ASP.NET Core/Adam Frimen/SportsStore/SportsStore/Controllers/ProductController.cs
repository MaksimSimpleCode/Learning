using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController:Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category,int productPage = 1)
        {
            return View(new ProductListViewModel
            {
                Products = repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                Paginginfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    Totalltems = category == null ?
                    repository.Products.Count() :
                    repository.Products.Where(e=>
                        e.Category==category).Count()
                },
                CurrentCategory = category
            }); ; 
        }
    }
}
