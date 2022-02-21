using ITech_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Service
{
    public interface ICustomerService
    {

        Customer GetById(int id);
        List<Customer> GetAll();
        void Create(Customer customer);
        void Update(Customer customer);
        void Remove(int id);

    }
}
