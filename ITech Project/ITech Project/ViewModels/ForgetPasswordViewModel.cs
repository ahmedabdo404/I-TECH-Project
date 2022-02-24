using System.ComponentModel.DataAnnotations;

namespace ITech_Project.ViewModels
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage ="Email is required!")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }
}
