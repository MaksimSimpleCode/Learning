using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class OrderController:Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;
        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout() //IActionResult потому что на форме будут происходить действия
        {

            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order) //IActionResult потому что на форме будут происходить действия
        {
            shopCart.listShopItems = shopCart.GetShopItems();
            if(shopCart.listShopItems.Count==0)
            {
                ModelState.AddModelError("", "Должны быть товары");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
