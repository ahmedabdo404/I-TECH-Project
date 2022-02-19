using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITech_Project.Models

{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="First Name is required !")]
        [RegularExpression(pattern: "[a-zA-Z]{3,}",ErrorMessage = "First Name must be letters only and more than 2 letters")]
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

        //[Required(ErrorMessage = "Email is required!")]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }

        //[DataType(DataType.PhoneNumber)]
        //[Required(ErrorMessage = "Phone Number is required !")]
        //public int? Phone { get; set; }

        //[DataType(DataType.Password)]
        //[Required(ErrorMessage = "Password is required !")]
        //public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Password and Confirm not matched")]
        //[DataType(DataType.Password)]
        //public string ComfirmedPassword { get; set; }

        ///---------------------------------
        [Required(ErrorMessage = "Credit Card is required!")]
        public string CreditCard { get; set; }

        [Required(ErrorMessage = "Credit Card Type Id is required!")]
        [MaxLength (14)]
        public int CreditCardTypeId { get; set; }

        [Required(ErrorMessage = "Card Exp Date is required!")]
        [DataType(DataType.Date)]
        public string CardExpDate { get; set; }

        public string BillingCountry { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public int? BillingPostalCode { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public int? ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        [DataType(DataType.Date)]
        public string DateEntered { get; set; }


        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public Order Order { get; set; }

    }
}
