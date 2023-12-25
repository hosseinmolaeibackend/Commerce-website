using System.ComponentModel.DataAnnotations;

namespace Test.ViewModels
{
    public class CreateArticleViewModel
    {
        [Display(Name = "title")]
        [Required(ErrorMessage = "enter the '{0}' ")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "enter the '{0}' ")]
        public string Description { get; set; }

        public IFormFile? Image { get; set; }
        public string? ImageName { get; set; }

        [Display(Name = "Date time")]
        [Required(ErrorMessage = "enter the '{0}' ")]
        public DateTime CreateTime { get; set; }
        public string? TimeRead { get; set; }
    }
}
