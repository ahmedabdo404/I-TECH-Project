using ITech_Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITech_Project.Service
{
    public interface IOrderService
    {
        Db Context { get; }

        int Create(Order ord);
        int Delete(int id);
        List<Order> GetAll();
        Order GetById(int id);
        int Update(Order ord);

        public Task StoreOrder(List<ShoppingCartItem> items, string UserId, string UserEmailAddress);
        public Task <List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);

    }
}