using ITech_Project.Models;
using System.Collections.Generic;

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

        void StoreOrder(List<ShoppingCartItem> items, string UserId, string UserEmailAddress);
        List<Order> GetOrdersByUserId(string userId);
    }
}