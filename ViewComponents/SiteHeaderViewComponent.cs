using Microsoft.AspNetCore.Mvc;

namespace Test.ViewComponents
{
    public class SiteHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("SiteHeader");
        }
    }
}
