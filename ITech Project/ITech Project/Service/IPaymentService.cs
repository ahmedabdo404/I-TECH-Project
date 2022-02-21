using ITech_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Service
{
    public interface IPaymentService
    {

        public Payment GetPaymentByType(string name);

        //Update payment info
        public void Update(Payment payment);

        //Get All Payment Types
        public List<Payment> GetAllTypes();


        //Remove payment type
        public void Remove(int Id);

        //To Create New Type of Payment
        public void Create(Payment payment);
    }
}
