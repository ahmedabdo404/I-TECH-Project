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

        [DataType(DataType.MultilineText)]
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

        [Required(ErrorMessage = "Mobile Model is required !")]
        [Display(Name = "Mobile Model")]
        public ModelMobile ModelMobile { get; set; }

        [Required(ErrorMessage = "Labtop Model is required !")]
        [Display(Name = "Labtop Model")]
        public ModelLabtop ModelLabtop { get; set; }

        [Display(Name = "Category")]
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
