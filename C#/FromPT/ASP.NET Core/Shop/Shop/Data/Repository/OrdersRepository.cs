using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContext appDbContext;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDbContext appDbContext, ShopCart shopCart)
        {
            this.appDbContext = appDbContext;
            this.shopCart = shopCart;
        }
        public void createOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDbContext.Order.Add(order);
            appDbContext.SaveChanges();

            var items = shopCart.listShopItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId=el.car.Id,
                    OrderId=order.Id,
                    Price=el.car.Price
                };
                appDbContext.OrderDetail.Add(orderDetail);
            }
            appDbContext.SaveChanges();
        }
    }
}
