using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITech_Project.ViewModels
{
    public class LoginViewModel
    {
       
        [Required(ErrorMessage ="Invalid email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Password must be not less than 6 letters!")]
        public string Password { get; set; }


        [Display (Name ="Remember me")]
        public bool RememberMe { get; set; }
    }
}
