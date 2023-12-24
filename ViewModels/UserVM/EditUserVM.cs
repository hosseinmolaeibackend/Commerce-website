using System.ComponentModel.DataAnnotations;

namespace Test.ViewModels.UserVM
{
    public class EditUserVM
    {
        public int UserId { get; set; }
        [Display(Name ="Name")]
        [Required(ErrorMessage ="Please Type {0}")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please Type {0}")]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Type {0}")]
        public string Password { get; set; }
        
        [Display(Name = "RePassword")]
        [Required(ErrorMessage = "Please Type {0}")]
        [Compare("Password")]
        public string RePassword { get; set; }
        public string? Phone { get; set; }

        public IFormFile? Profilimg { get; set; }
        public string? ProfilimgName { get; set; }
    }
}
