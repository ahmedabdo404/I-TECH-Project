using System.ComponentModel.DataAnnotations;

namespace ITech_Project.Models
{
    public class Payment
    {

        public int ID { get; set; }

        [Required]
        public string PaymentType { get; set; }
        public bool Allowed { get; set; }
    }
}
