using System;
using System.ComponentModel.DataAnnotations;

namespace ITech_Project.Models

{
    public class Customer
    {
        public int Id { get; set; }


        [Display(Name ="First Name")]
        [Required(ErrorMessage = "First Name is required !")]
        [RegularExpression(pattern: "[a-zA-Z]{3,}", ErrorMessage = "First Name must be letters only and more than 2 letters")]
        public string FirstName { get; set; }


        [Display(Name ="Last Name")]
        [RegularExpression(pattern: "[a-zA-Z]{3,}", ErrorMessage = "Last Name must be letters only and more than 2 letters")]
        [Required(ErrorMessage = "Last Name is required !")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Address is required !")]
        [MaxLength(50)]
        public string Address { get; set; }


        [Required(ErrorMessage = "City is required !")]
        public string City { get; set; }


        [Display(Name ="Postal Code")]
        [DataType(DataType.PostalCode)]
        public int? PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required !")]
        public string Country { get; set; }


        [Display(Name = "Credit Card")]
        [Required(ErrorMessage = "Credit Card Type Id is required!")]
        [MaxLength(14)]
       // [RegularExpression("[0-9]")]
        public string CreditCardTypeId { get; set; }


        [Display(Name = "Card Expiration Date")]
        [Required(ErrorMessage = "Card Exp Date is required!")]
        [DataType(DataType.Date)]
        public DateTime CardExpDate { get; set; }


        [Display(Name = "Billing Country")]
        public string BillingCountry { get; set; }


        [Display(Name = "Billing Address")]
        public string BillingAddress { get; set; }


        [Display(Name = "Billing City")]
        [Required(ErrorMessage = "Billing City is required!")]
        public string BillingCity { get; set; }



        [Display(Name = "Ship Address")]
        [Required(ErrorMessage = "Ship Address is required!")]
        public string ShipAddress { get; set; }



        [Display(Name = "Ship City")]
        [Required(ErrorMessage = "Ship City is required!")]
        public string ShipCity { get; set; }



        [Display(Name = "Ship Country")]
        [Required(ErrorMessage = "Ship Country is required!")]
        public string ShipCountry { get; set; }


        [Display(Name = "Date Entered")]
        [DataType(DataType.Date)]
        public DateTime DateEntered { get; set; }


      

    }
}
