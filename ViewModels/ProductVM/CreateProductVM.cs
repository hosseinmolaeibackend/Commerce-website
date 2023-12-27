using System.ComponentModel.DataAnnotations;

namespace Test.ViewModels.ProductVM;

public class CreateProductVM
{
    [Required]
    [Display(Name = "Name")]
    public string ProductName { get; set; }
    [Required]
    [Display(Name = "Description")]
    public string ProductDescription { get; set; }
    [Required]
    [Display(Name = "Price")]
    public decimal Price { get; set; }
    [Required]
    [Display(Name = "User Id")]
    public int UserId { get; set; }
}