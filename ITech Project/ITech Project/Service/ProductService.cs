using ITech_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;

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

        public void AddReview(int id, int Rank)
        {
            if (Context.Products.FirstOrDefault(x => x.Id == id).NumberOfReviews == null)
                Context.Products.FirstOrDefault(x => x.Id == id).NumberOfReviews = 1;
            else
                Context.Products.FirstOrDefault(x => x.Id == id).NumberOfReviews++;

            if (Context.Products.FirstOrDefault(x => x.Id == id).TotalReviews == null)
                Context.Products.FirstOrDefault(x => x.Id == id).TotalReviews = Rank;
            else
                Context.Products.FirstOrDefault(x => x.Id == id).TotalReviews += Rank;

            Context.Products.FirstOrDefault(x => x.Id == id).Ranking =
                Context.Products.FirstOrDefault(x => x.Id == id).TotalReviews / Context.Products.FirstOrDefault(x => x.Id == id).NumberOfReviews;

            Context.SaveChanges();
        }
    }
}
