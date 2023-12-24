using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    public class FaqsController : Controller
    {
        public IActionResult Faqs()
        {
            return View();
        }
    }
}
