using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.ViewModels
{
    public class SignUpViewModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(pattern: @"[a-zA-z]{3,}", ErrorMessage = "please enter letters or Name must be more than 3 letters !")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "Exist", controller: "Account", ErrorMessage = "This e-mail is already exist !")]
        public string Email { get; set; }


        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number is required !")]
        public string Phone { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required !")]
        public string Password { get; set; }


        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm not matched")]
        [DataType(DataType.Password)]
        public string ComfirmPassword { get; set; }
    }
}
