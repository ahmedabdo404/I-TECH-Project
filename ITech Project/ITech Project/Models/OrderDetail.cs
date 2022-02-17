using System.ComponentModel.DataAnnotations;

namespace ITech_Project.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        [Display(Name = "Order Number")]
        [Required(ErrorMessage = "Order Number Is Required")]
        public int OrderNumber { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price Is Required")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity Is Required")]
        public int Quantity { get; set; }

        [Display(Name = "Discount")]
        public int Discount { get; set; }

        [Display(Name = "Total")]
        [Required(ErrorMessage = "Total Is Required")]
        [DataType(DataType.Currency)]
        public int Total { get; set; }

        [Display(Name = "Model")]
        [Required(ErrorMessage = "Model Is Required")]
        public string Model { get; set; }

        [Display(Name = "Color")]
        [Required(ErrorMessage = "Color Is Required")]
        public string Color { get; set; }

        [Display(Name = "Ship Date")]
        [Required(ErrorMessage = "Ship Date Is Required")]
        [DataType(DataType.Date)]
        public string ShipDate { get; set; }

        [Display(Name = "Bill Date")]
        [Required(ErrorMessage = "Bill Date Is Required")]
        [DataType(DataType.Date)]
        public string BillDate { get; set; }

        /* [ForeignKey("Order")]
         public int Order_Id { get; set; }
         public Order Order { get; set; }

         [ForeignKey("Product")]
         public int Product_Id { get; set; }
         public Product Product { get; set; }
         */




    }
}
