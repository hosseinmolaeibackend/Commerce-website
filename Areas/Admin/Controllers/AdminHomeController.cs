using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Test.Areas.Admin.Controllers;

public class AdminHomeController:AdminBaseController
{
    public IActionResult AdminHome()
    {
        return View();
    }
}