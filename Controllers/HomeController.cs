using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("about-us")]
        public IActionResult About_Us()
        {
            return View();
        }

   
    }
}