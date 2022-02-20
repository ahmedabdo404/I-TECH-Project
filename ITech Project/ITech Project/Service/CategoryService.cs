using ITech_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly Db Context;

        public CategoryService(Db context)
        {
            Context = context;
        }
        //create
        public void Create(Category category)
        {
            Context.Categories.Add(category);
            Context.SaveChanges();
        }
        //read
        public List<Category> GetAll()
        {
            return Context.Categories.ToList();
        }
        public Category GetById(int id)
        {
            return Context.Categories.FirstOrDefault(c => c.Id == id);
        }
        public Category GetByName(string name)
        {
            return Context.Categories.FirstOrDefault(x => x.Name == name);
        }
        //update
        public void Update(Category category)
        {
            Context.Categories.Update(category);
            Context.SaveChanges();
        }
        //delete
        public void Delete(int id)
        {
            Context.Categories.Remove(Context.Categories.FirstOrDefault(x => x.Id == id));
            Context.SaveChanges();
        }
    }
}
