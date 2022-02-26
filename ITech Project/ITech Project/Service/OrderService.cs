using ITech_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Service
{
    public class OrderService : IOrderService
    {

        // Services Order Model CRUD
        public Db Context { get; }

        public OrderService(Db _context)
        {
            Context = _context;
        }

        //Read All
        public List<Order> GetAll()
        {
            return Context.Orders.ToList();
        }
        //Read One
        public Order GetById(int id)
        {
            return Context.Orders.FirstOrDefault(i => i.Id == id);
        }

        //Create
        public int Create(Order ord)
        {
            Context.Orders.Add(ord);
            int row = Context.SaveChanges();
            return row;
        }
        //Update
        public int Update(Order ord)
        {
            Context.Update(ord);
            int row = Context.SaveChanges();
            return row;
        }
        //Delete
        public int Delete(int id)
        {
            Context.Remove(Context.Orders.FirstOrDefault(i => i.Id == id));
            int row = Context.SaveChanges();
            return row;
        }

        public void StoreOrder(List<ShoppingCartItem> items, string UserId, string UserEmailAddress)
        {
            var order = new Order()
            {
                UserId = UserId,
                Email = UserEmailAddress
            };
            Context.Orders.Add(order);
            Context.SaveChanges();

            foreach (var item in items)
            {
                var orderitem = new OrderDetail()
                {
                    Price =item.product.UnitPrice,
                    ProductId = item.product.Id,
                    Quantity = item.Amount,
                    OrderId = order.Id

                };
                Context.Add(orderitem);
            }
            Context.SaveChanges();

        }


        public List<Order> GetOrdersByUserId(string userId)
        {
              var orders = Context.Orders.Include(n=>n.OrderDetails).ThenInclude(n=>n.Product).Where(n=>n.UserId==
                  userId).ToList();
            return orders;
        }
    }
}
