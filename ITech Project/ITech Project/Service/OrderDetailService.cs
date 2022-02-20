using ITech_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Service
{
    public class OrderDetailService : IOrderDetailService
    {
        // Services Order Model CRUD
        public Db Context { get; }
        public OrderDetailService(Db _context)
        {
            Context = _context;
        }

        //Read All
        public List<OrderDetail> GetAll()
        {
            return Context.OrderDetails.ToList();
        }
        //Read One
        public OrderDetail GetById(int id)
        {
            return Context.OrderDetails.FirstOrDefault(i => i.Id == id);
        }

        //Create
        public int Create(OrderDetail ord)
        {
            Context.OrderDetails.Add(ord);
            int row = Context.SaveChanges();
            return row;
        }
        //Update
        public int Update(OrderDetail ord)
        {
            Context.Update(ord);
            int row = Context.SaveChanges();
            return row;
        }
        //Delete
        public int Delete(int id)
        {
            Context.Remove(Context.OrderDetails.FirstOrDefault(i => i.Id == id));
            int row = Context.SaveChanges();
            return row;
        }
    }
}
