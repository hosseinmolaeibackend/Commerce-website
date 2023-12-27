using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Test.Context;
using Test.ViewModels.ProductVM;

namespace Test.Areas.Admin.Controllers;

public class ProductController : AdminBaseController
{
    #region context
    private readonly ApplicationContext _db;
    public ProductController(ApplicationContext context)
    {
        _db = context;
    }
    #endregion
   
    // GET
    public IActionResult ShowProduct()
    {
        ViewData["Title"] = "Product";
        return View(_db.ProductModels.ToList());
    }

    #region Create Product

    [HttpGet]
    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost,ValidateAntiForgeryToken]
    public IActionResult CreateProduct(CreateProductVM createProductVm)
    {
        var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (ModelState.IsValid)
        {
           
        }
        return RedirectToAction("ShowProduct", "Product", new { area = "Admin" });
    }
    #endregion
}