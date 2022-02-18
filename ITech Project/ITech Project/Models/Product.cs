using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITech_Project.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitPrice { get; set; }
        public string SupplierProductID { get; set; }
        public int QuantityPerUnitShipped { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public bool ProductAvailable { get; set; }
        public bool DiscountAvailable { get; set; }
        public double Discount { get; set; }
        public string Picture { get; set; }
        public int Ranking { get; set; }
        public string Note { get; set; }
        //public int ReorderLevel { get; set; }

        //[ForeignKey("Supplier")]
        //[Display(Name = "Supplier")]
        //public int SupplierID { get; set; }
        //public Supplier Supplier { get; set; }

        [ForeignKey("Model")]
        [Display(Name = "Model")]
        public int ModelID { get; set; }
        public Model Model { get; set; }

        [ForeignKey("Category")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Color")]
        [Display(Name= "Color")]
        public int ColorID { get; set; }
        public Color Color { get; set; }

    }
}
