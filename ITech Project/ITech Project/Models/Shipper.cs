using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITech_Project.Models
{
    public class Shipper
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]

        public int Phone { get; set; }
         

        
    }
}
