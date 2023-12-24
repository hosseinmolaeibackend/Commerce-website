using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    public class CommerceController : Controller
    {
        [Route("/Commerce")]
        public IActionResult Commerce()
        {
            return View();
        }
    }
}
