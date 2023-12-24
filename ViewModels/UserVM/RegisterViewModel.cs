using System.ComponentModel.DataAnnotations;

namespace Test.ViewModels.UserVM
{
    public class RegisterViewModel
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please type {0}")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please type {0}")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please type {0}")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Re-Password")]
        [Required(ErrorMessage = "Please type {0}")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "These two entries are not equal")]
        public string RePassword { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        public IFormFile? Profilimg { get; set; }
        public string? ProfilimgName { get; set; }
    }
}
