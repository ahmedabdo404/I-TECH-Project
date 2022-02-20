using ITech_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Service
{
    public class ShipperService : IShipperService
    {
        private readonly Db Context;

        public ShipperService(Db context)
        {
            Context = context;
        }

        //create
        public void Create(Shipper shipper)
        {
            Context.Shippers.Add(shipper);
            Context.SaveChanges();
        }
        //read
        public List<Shipper> GetAll()
        {
            return Context.Shippers.ToList();
        }
        public Shipper GetById(int id)
        {
            return Context.Shippers.FirstOrDefault(c => c.Id == id);
        }
        public Shipper GetByName(string name)
        {
            return Context.Shippers.FirstOrDefault(x => x.CompanyName == name);
        }
        //update
        public void Update(Shipper shipper)
        {
            Context.Shippers.Update(shipper);
            Context.SaveChanges();
        }
        //delete
        public void Delete(int id)
        {
            Context.Shippers.Remove(Context.Shippers.FirstOrDefault(x => x.Id == id));
            Context.SaveChanges();
        }




    }
}
