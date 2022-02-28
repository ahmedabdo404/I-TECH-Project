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
        public double UnitPrice { get; set; }


        [Display(Name = "Units In Stock")]
        public int UnitsInStock { get; set; }

        public double Discount { get; set; }

        [Required(ErrorMessage = "Picture is required !")]
        public string Picture { get; set; }

        [Range(1, 5)]
        public byte? Ranking { get; set; }
        public string Note { get; set; }
        public Color Color { get; set; }

        [Required(ErrorMessage = "Category is required !")]
        public Category Category { get; set; }

        [Display(Name = "Mobile Model")]
        public ModelMobile? ModelMobile { get; set; }

        [Display(Name = "Labtop Model")]
        public ModelLabtop? ModelLabtop { get; set; }

        public Accessories? Accessories { get; set; }

        [Display(Name ="Supplier")]
        [ForeignKey("Supplier")]
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
