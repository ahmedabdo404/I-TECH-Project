using ITech_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITech_Project.Service
{
    public class OrderService : IOrderService
    {
        private readonly Db Context;

        // Services Order Model CRUD
        Db IOrderService.Context { get; }

        public OrderService(Db _context)
        {
            Context = _context;
        }

        //Read All
        List<Order> IOrderService.GetAll()
        {
            return ((IOrderService)this).Context.Orders.ToList();
        }
        //Read One
        Order IOrderService.GetById(int id)
        {
            return ((IOrderService)this).Context.Orders.FirstOrDefault(i => i.Id == id);
        }

        //Create
        int IOrderService.Create(Order ord)
        {
            ((IOrderService)this).Context.Orders.Add(ord);
            int row = ((IOrderService)this).Context.SaveChanges();
            return row;
        }
        //Update
        int IOrderService.Update(Order ord)
        {
            ((IOrderService)this).Context.Update(ord);
            int row = ((IOrderService)this).Context.SaveChanges();
            return row;
        }
        //Delete
        int IOrderService.Delete(int id)
        {
            ((IOrderService)this).Context.Remove(((IOrderService)this).Context.Orders.FirstOrDefault(i => i.Id == id));
            int row = ((IOrderService)this).Context.SaveChanges();
            return row;
        }
        
    public async Task StoreOrder(List<ShoppingCartItem> items, string UserId, string UserEmailAddress)
        {

            var order = new Order()
            {
                UserId = UserId,
                Email = UserEmailAddress
            };
            await Context.Orders.AddAsync(order);
            await Context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderitem = new OrderDetail()
                {
                    Price = item.product.UnitPrice,
                    ProductId = item.product.Id,
                    Quantity = item.Amount,
                    OrderId = order.Id

                };
                await Context.OrderDetails.AddAsync(orderitem);
            }
            await Context.SaveChangesAsync();

        }


        public async Task<List<Order>> GetOrdersByUserId(string userId)
        {
            var orders = await Context.Orders.Include(n => n.OrderDetails).ThenInclude(n => n.Product).Where(n => n.UserId ==
                      userId).ToListAsync();
            return orders;
        }
    }
}
