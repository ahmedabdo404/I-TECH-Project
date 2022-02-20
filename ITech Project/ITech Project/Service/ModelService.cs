using ITech_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Service
{
    public class ModelService : IModelService
    {
        private readonly Db Context;

        public ModelService(Db context)
        {
            Context = context;
        }

        //craete
        public void Create(Model model)
        {
            Context.Models.Add(model);
            Context.SaveChanges();
        }
        //read
        public List<Model> GetAll()
        {
            return Context.Models.ToList();
        }
        public Model GetById(int id)
        {
            return Context.Models.FirstOrDefault(x => x.Id == id);
        }
        public Model GetByName(string name)
        {
            return Context.Models.FirstOrDefault(x => x.Name == name);
        }
        //update
        public void Update(Model model)
        {
            Context.Models.Update(model);
            Context.SaveChanges();
        }
        //delete
        public void Delete(int id)
        {
            Context.Models.Remove(Context.Models.FirstOrDefault(x => x.Id == id));
            Context.SaveChanges();
        }


    }
}
