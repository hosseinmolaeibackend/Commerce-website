using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    public class ArticleController : Controller
    {
        [Route("/article")]
        public IActionResult Article()
        {
            return View();
        }
    }
}
