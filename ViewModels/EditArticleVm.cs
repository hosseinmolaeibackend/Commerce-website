using System.ComponentModel.DataAnnotations;

namespace Test.ViewModels;

public class EditArticleVm
{
    
    public int ArticleId { get; set; }
    [Required]
    [Display(Name = "title")]
    public string Title { get; set; }
    [Required]
    [Display(Name = "description")]
    public string Description { get; set; }
    
    public IFormFile? Image { get; set; }
    public string? ImageName { get; set; }
    
    [Required]
    [Display(Name = "createtime")]
    public DateTime CreateTime { get; set; }
    [Display(Name = "timeread")]
    public string? TimeRead { get; set; }
    [Required]
    public int UserId { get; set; }
}