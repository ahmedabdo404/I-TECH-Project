using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITech_Project.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactFName { get; set; }
        [Required]
        public string ContactLName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int postalCode { get; set; }
        public string Country { get; set; }

        [Required]

        public int Phone { get; set; }

        [Required]
        public string Email { get; set; }
        public string Url { get; set; }
        public string paymentMethod { get; set; }
        public string TypeGoods { get; set; }
        public bool DiscountAvaiable { get; set; }
        public string Logo { get; set; }

        [ForeignKey("Customer")]
        public int CustId { get; set; }

        public virtual Customer Customer { get; set; }













    }
}
