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
            return  Context.Orders.ToList();
        }
        //Read One
        Order IOrderService.GetById(int id)
        {
            return  Context.Orders.FirstOrDefault(i => i.Id == id);
        }

        //Create
        int IOrderService.Create(Order ord)
        {
             Context.Orders.Add(ord);
            int row = Context.SaveChanges();
            return row;
        }
        //Update
        int IOrderService.Update(Order ord)
        {
             Context.Update(ord);
            int row =  Context.SaveChanges();
            return row;
        }
        //Delete
        int IOrderService.Delete(int id)
        {
             Context.Remove(Context.Orders.FirstOrDefault(i => i.Id == id));
            int row =  Context.SaveChanges();
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


        public async Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole)
        {
            var orders = await Context.Orders.Include(n => n.OrderDetails).ThenInclude(n => n.Product)
                .Include(n => n.User).ToListAsync();
            if(userRole != "Admin")
            {
                orders = orders.Where(n => n.UserId == userId).ToList();
            }
            return orders;
        }
    }
}
