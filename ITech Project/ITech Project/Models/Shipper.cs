using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITech_Project.Models
{
    public class Shipper
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Company Name Is Required")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Phone Is Required")]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
         

        
    }
}
