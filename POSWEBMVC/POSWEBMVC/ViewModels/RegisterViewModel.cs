using System.ComponentModel.DataAnnotations;

namespace POSWEBMVC.ViewModels
{
    public class RegisterVm : LoginVm
    {
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}