using ITech_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly Db Context;
        public PaymentService(Db context)
        {
            Context = context;
        }


        //Get Payment by type
        public Payment GetPaymentByType(string name)
        {
            return Context.Payments.FirstOrDefault(p => p.PaymentType == name);
        }

        //Update payment info
        public void Update(Payment payment)
        {
            Context.Payments.Update(payment);
            Context.SaveChanges();
        }

        //Get All Payment Types
        public List<Payment> GetAllTypes()
        {
            return Context.Payments.ToList();
        } 


        //Remove payment type
        public void Remove(int Id)
        {
            var payment = Context.Payments.FirstOrDefault(p => p.Id == Id);
            Context.Payments.Remove(payment);
            Context.SaveChanges();
        }

        //To Create New Type of Payment
        public void Create(Payment payment)
        {
            Context.Payments.Add(payment);
            Context.SaveChanges();
        }

    }
}
