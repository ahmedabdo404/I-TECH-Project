using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITech_Project.Enums;


namespace ITech_Project.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company Name Is Required")]
        public string CompanyName { get; set; }
        [Display(Name = "Contact FirstName")]

        [Required(ErrorMessage = "Contact FName Is Required")]
        public string ContactFName { get; set; }

        [Display(Name = "Contact LastName")]
        [Required(ErrorMessage = "Contact LName Is Required")]
        public string ContactLName { get; set; }

        [Required(ErrorMessage = "Address Is Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City Is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Country Is Required")]
        public string Country { get; set; }

        [DataType(DataType.PostalCode)]
        public int? PostalCode { get; set; }

        public string Url { get; set; }

        [Required(ErrorMessage = "Type Goods Is Required")]
        public Category TypeGoods { get; set; }
        public string Logo { get; set; }

        [Required(ErrorMessage = "payment Method Is Required")]
        public Payment Payment { get; set; }
    }
}
