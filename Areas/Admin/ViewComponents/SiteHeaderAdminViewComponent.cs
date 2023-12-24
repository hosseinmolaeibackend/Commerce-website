using Microsoft.AspNetCore.Mvc;

namespace Test.Areas.Admin.ViewComponents;

public class SiteHeaderAdminViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("SiteHeaderAdmin");
    }
}