using ITech_Project.Models;
using System.Collections.Generic;

namespace ITech_Project.Service
{
    public interface IProductService
    {
        void Create(Product product);
        void Delete(int id);
        List<Product> GetAll();
        Product GetById(int id);
        Product GetByName(string name);
        void Update(Product product);
    }
}