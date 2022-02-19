using ITech_Project.Models;
using System.Collections.Generic;

namespace ITech_Project.Service
{
    public interface IOrderDetailService
    {
        Db Context { get; }

        int Create(OrderDetail ord);
        int Delete(int id);
        List<OrderDetail> GetAll();
        OrderDetail GetById(int id);
        int Update(OrderDetail ord);
    }
}