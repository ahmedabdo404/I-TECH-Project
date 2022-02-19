using ITech_Project.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITech_Project.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required !")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required !")]
        public int UnitPrice { get; set; }

        public string SupplierProductId { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? QuantityPerUnitShipped { get; set; }

        [Required(ErrorMessage = "Product Available is required !")]
        public bool ProductAvailable { get; set; }
        public bool? DiscountAvailable { get; set; }
        public double? Discount { get; set; }

        [Required(ErrorMessage = "Picture is required !")]
        public string Picture { get; set; }
        public int? Ranking { get; set; }
        public string Note { get; set; }
        public Color Color { get; set; }

        [ForeignKey("Supplier")]
        [Display(Name = "Supplier")]
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [ForeignKey("Model")]
        [Display(Name = "Model")]
        public int? ModelId { get; set; }
        public Model Model { get; set; }

        [ForeignKey("Category")]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
