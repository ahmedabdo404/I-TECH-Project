using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITech_Project.Enums;

namespace ITech_Project.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Order Number")]
        [Required(ErrorMessage = "Order Number Is Required")]
        public int OrderNumber { get; set; }


        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public string OrderDate { get; set; }

        [Display(Name = "Ship Date")]
        [DataType(DataType.Date)]
        public string ShipDate { get; set; }


        [DataType(DataType.Currency)]
        public int? Freight { get; set; }

        public string Timestamp { get; set; }
 

        [Display(Name = "Payment Date")]
        [DataType(DataType.Date)]
        public string PaymentDate { get; set; }

        [Display(Name = "Customer")]
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "Payment Is Required")]
        public Payment Payment { get; set; }

        [Required(ErrorMessage = "Shipper Is Required")]
        public Shipper Shipper { get; set; }


    }
}
