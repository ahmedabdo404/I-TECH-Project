using System.ComponentModel.DataAnnotations;

namespace ITech_Project.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required !")]
        public string Name { get; set; }
    }
}
