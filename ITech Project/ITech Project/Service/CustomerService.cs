using ITech_Project.Models;
using System.Collections.Generic;
using System.Linq;


namespace ITech_Project.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly Db Context;
        public CustomerService(Db context)
        {
            Context = context;
        }

        //Read One Customer
        public Customer GetById(int Id)
        {
            return Context.Customers.FirstOrDefault(c => c.Id == Id);
        }


        //Read All Customers
        public List<Customer> GetAll()
        {
            return Context.Customers.ToList();
        }


        //Create New Customer to make admin test
        public void Create(Customer customer)
        {
            Context.Customers.Add(customer);
            Context.SaveChanges();
        }


        //Update info of any Customer
        public void Update(Customer customer)
        {
            Context.Customers.Update(customer);
            Context.SaveChanges();
        }

        //To Remove Any Customer
        public void Remove(int Id)
        {
            var customer = Context.Customers.FirstOrDefault(c => c.Id == Id);
            Context.Customers.Remove(customer);
            Context.Users.Remove(Context.Users.FirstOrDefault(c => c.UserName == customer.FirstName));
            Context.SaveChanges();
        }

    }
}
