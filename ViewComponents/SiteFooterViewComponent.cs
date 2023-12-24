using Microsoft.AspNetCore.Mvc;

namespace Test.ViewComponents
{
    public class SiteFooterViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View("SiteFooter");
        }
    }
}
