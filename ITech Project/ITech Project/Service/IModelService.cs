using ITech_Project.Models;
using System.Collections.Generic;

namespace ITech_Project.Service
{
    public interface IModelService
    {
        void Create(Model model);
        void Delete(int id);
        List<Model> GetAll();
        Model GetById(int id);
        Model GetByName(string name);
        void Update(Model model);
    }
}