using System.ComponentModel.DataAnnotations;


namespace ITech_Project.ViewModels
{
    public class RoleViewModel
    {

        [Required(ErrorMessage ="Role Name is required!")]
        [Display(Name ="Role Name")]
        public string RoleName { get; set; }
    }
}
