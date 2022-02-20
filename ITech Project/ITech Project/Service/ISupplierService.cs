using ITech_Project.Models;
using System.Collections.Generic;

namespace ITech_Project.Service
{
    public interface ISupplierService
    {
        void Create(Supplier Supplier);
        void Delete(int id);
        void Update(Supplier Supplier);
        List<Supplier> GetAll();
        Supplier GetById(int id);
        Supplier GetByName(string name);
    }
}
