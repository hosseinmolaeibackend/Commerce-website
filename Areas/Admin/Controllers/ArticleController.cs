using Microsoft.AspNetCore.Mvc;
using Test.ViewModels;

namespace Test.Areas.Admin.Controllers
{
    public  class ArticleController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Creat Article
        public IActionResult Creat()
        {
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Creat(CreateArticleViewModel createArticleVM)
        {
            return RedirectToAction("Index");
        }
        #endregion
    }
}
