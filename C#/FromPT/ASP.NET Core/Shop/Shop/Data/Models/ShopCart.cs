using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shop.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContext appDbContext;
        public ShopCart(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public string ShopCardId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);
            return new ShopCart(context) { ShopCardId = shopCartId };
        }

        public void AddToCard(Car car)
        {
            this.appDbContext.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCardId,
                car = car,
                price = car.Price
            });
            appDbContext.SaveChanges();
        }
        public List<ShopCartItem> GetShopItems()
        {
            return appDbContext.ShopCartItem.Where(c => c.ShopCartId == ShopCardId).Include(s => s.car).ToList();
        }



}
}
