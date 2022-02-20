using ITech_Project.Models;
using System.Collections.Generic;

namespace ITech_Project.Service
{
    public interface ICategoryService
    {
        void Create(Category category);
        void Delete(int id);
        List<Category> GetAll();
        Category GetById(int id);
        Category GetByName(string name);
        void Update(Category category);
    }
}