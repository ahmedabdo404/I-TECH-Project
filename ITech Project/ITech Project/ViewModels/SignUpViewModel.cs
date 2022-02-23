using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITech_Project.ViewModels
{
    public class SignUpViewModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number is required !")]
        public int? Phone { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required !")]
        public string Password { get; set; }


        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm not matched")]
        [DataType(DataType.Password)]
        public string ComfirmPassword { get; set; }
    }
}
