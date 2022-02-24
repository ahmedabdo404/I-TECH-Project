using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITech_Project.Models

{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required !")]
        [RegularExpression(pattern: "[a-zA-Z]{3,}", ErrorMessage = "First Name must be letters only and more than 2 letters")]
        public string FirstName { get; set; }

        [RegularExpression(pattern: "[a-zA-Z]{3,}", ErrorMessage = "Last Name must be letters only and more than 2 letters")]
        [Required(ErrorMessage = "Last Name is required !")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Address is required !")]
        [MaxLength(50)]
        public string Address { get; set; }


        [Required(ErrorMessage = "City is required !")]
        public string City { get; set; }

        [DataType(DataType.PostalCode)]
        public int? PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required !")]
        public string Country { get; set; }


        [Required(ErrorMessage = "Credit Card Type Id is required!")]
        [MaxLength(14)]
        [RegularExpression("[0-9]")]
        public string CreditCardTypeId { get; set; }

        [Required(ErrorMessage = "Card Exp Date is required!")]
        [DataType(DataType.Date)]
        public string CardExpDate { get; set; }
        public string BillingCountry { get; set; }
        public string BillingAddress { get; set; }

        [Required(ErrorMessage = "Billing City is required!")]
        public string BillingCity { get; set; }

        [Required(ErrorMessage = "Ship Address is required!")]
        public string ShipAddress { get; set; }

        [Required(ErrorMessage = "Ship City is required!")]
        public string ShipCity { get; set; }

        [Required(ErrorMessage = "Ship Country is required!")]
        public string ShipCountry { get; set; }

        [DataType(DataType.Date)]
        public string DateEntered { get; set; }


      

    }
}
