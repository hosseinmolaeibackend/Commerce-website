using Microsoft.AspNetCore.Mvc;

namespace Test.Areas.Admin.ViewComponents;

public class SiteFooterAdminViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View("SiteFooterAdmin");
    }
}