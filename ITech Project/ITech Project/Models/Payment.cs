using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITech_Project.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Display(Name = "Payment Type")]
        [Required(ErrorMessage = "Payment Type Is Required")]
        public string PaymentType { get; set; }
        public bool Allowed { get; set; }
    }
}
