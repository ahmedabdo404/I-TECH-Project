using ITech_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Service
{
    public class ProductService : IProductService
    {
        private readonly Db Context;

        public ProductService(Db context)
        {
            Context = context;
        }
        //craete
        public void Create(Product product)
        {
            Context.Products.Add(product);
            Context.SaveChanges();
        }
        //read
        public List<Product> GetAll()
        {
            return Context.Products.Include(x => x.Supplier).ToList();
        }
        public Product GetById(int id)
        {
            return Context.Products.Include(x => x.Supplier).FirstOrDefault(x => x.Id == id);
        }
        public Product GetByName(string name)
        {
            return Context.Products.FirstOrDefault(x => x.Name == name);
        }
        //update
        public void Update(Product product)
        {
            Context.Products.Update(product);
            Context.SaveChanges();
        }
        //delete
        public void Delete(int id)
        {
            Context.Products.Remove(Context.Products.FirstOrDefault(x => x.Id == id));
            Context.SaveChanges();
        }

    }
}
