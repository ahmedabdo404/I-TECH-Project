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

        [Display(Name = "Unit Price")]
        [Required(ErrorMessage = "Price is required !")]
        public int UnitPrice { get; set; }

        [Display(Name = "Supplier Product Id")]
        public string SupplierProductId { get; set; }

        [Display(Name = "Units In Stock")]
        public int? UnitsInStock { get; set; }

        [Display(Name = "Units On Order")]
        public int? UnitsOnOrder { get; set; }

        [Display(Name = "Quantity Per Unit Shipped")]
        public int? QuantityPerUnitShipped { get; set; }

        [Display(Name = "Product Available")]
        [Required(ErrorMessage = "Product Available is required !")]
        public bool ProductAvailable { get; set; }

        [Display(Name = "Discount Available")]
        public bool? DiscountAvailable { get; set; }
        public double? Discount { get; set; }

        [Required(ErrorMessage = "Picture is required !")]
        public string Picture { get; set; }
        public int? Ranking { get; set; }
        public string Note { get; set; }
        public Color Color { get; set; }

        [Display(Name = "Supplier")]
        [ForeignKey("Supplier")]
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [Display(Name = "Model")]
        [ForeignKey("Model")]
        public int? ModelId { get; set; }
        public Model Model { get; set; }

        [Display(Name = "Category")]
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
