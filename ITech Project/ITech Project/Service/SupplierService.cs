using ITech_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Service
{
    public class SupplierService : ISupplierService
    {

        private readonly Db Context;

        public SupplierService(Db context)
        {
            Context = context;
        }

        public void Create(Supplier Supplier)
        {
            Context.Suppliers.Add(Supplier);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var supplier = Context.Suppliers.FirstOrDefault(x => x.Id == id);
            Context.Suppliers.Remove(supplier);
            Context.Users.Remove(Context.Users.FirstOrDefault(x => x.UserName == supplier.ContactFName));
            Context.SaveChanges();
        }

        public List<Supplier> GetAll()
        {
            return Context.Suppliers.ToList();
        }

        public Supplier GetById(int id)
        {
            return Context.Suppliers.FirstOrDefault(x => x.Id == id);
        }

        public Supplier GetByName(string name)
        {
            return Context.Suppliers.FirstOrDefault(x => x.CompanyName == name);
        }

        public void Update(Supplier Supplier)
        {
            Context.Suppliers.Update(Supplier);
            Context.SaveChanges();
        }
    }
}
