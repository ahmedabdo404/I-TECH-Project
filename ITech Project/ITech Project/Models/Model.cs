using System.ComponentModel.DataAnnotations;

namespace ITech_Project.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
