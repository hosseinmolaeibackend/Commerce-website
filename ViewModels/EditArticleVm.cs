using System.ComponentModel.DataAnnotations;

namespace Test.ViewModels;

public class EditArticleVm
{
    
    public int ArticleId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    
    public IFormFile? Image { get; set; }
    public string? ImageName { get; set; }
    
    [Required]
    public DateTime CreateTime { get; set; }
    public string? TimeRead { get; set; }
    [Required]
    public int UserId { get; set; }
}