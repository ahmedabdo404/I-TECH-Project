using System.ComponentModel.DataAnnotations;

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
        public int PostalCode { get; set; }


        [Required]
        public string Country { get; set; }


        [Required(ErrorMessage = "Phone Number is required !")]
        public int Phone { get; set; }

        [Required]
        public string Password { get; set; }

        ///---------------------------------
        [Required]
        public string CreditCard { get; set; }

        [Required]
        public int CreditCardTypeID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string CardExpMonth { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public string CardExpYear { get; set; }

        [Required]
        public string BillingAddress { get; set; }

        [Required]
        public string BillingCity { get; set; }

        [Required]
        public string BillingRegion { get; set; }
        public int BillingPostalCode { get; set; }

        [Required]
        public string BillingCountry { get; set; }

        [Required]
        [MaxLength(50)]
        public string ShipAddress { get; set; }

        [Required]
        public string ShipCity { get; set; }

        [Required]
        public string ShipRegion { get; set; }

        [Required]
        public int ShipPostalCode { get; set; }

        [Required]
        public string ShipCountry { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string DateEntered { get; set; }

    }
}
