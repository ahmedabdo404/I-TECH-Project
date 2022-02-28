using ITech_Project.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITech_Project.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price Is Required")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity Is Required")]
        public int Quantity { get; set; }

        [Display(Name = "Discount")]
        public double Discount { get; set; }

        [Display(Name = "Total")]
        [Required(ErrorMessage = "Total Is Required")]
        [DataType(DataType.Currency)]
        public double Total { get; set; }

        [Display(Name = "Order")]
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public Order Order { get; set; }

        [Display(Name = "Product")]
        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public Product Product { get; set; }

        





    }
}
