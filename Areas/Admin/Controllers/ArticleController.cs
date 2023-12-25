using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Test.Context;
using Test.Models.Article;
using Test.Utilities;
using Test.ViewModels;
using WebApplication2.Utilities.ImageHelper;

namespace Test.Areas.Admin.Controllers
{
    public class ArticleController : AdminBaseController
    {
        #region Injection context db

        private readonly ApplicationContext _db;

        public ArticleController(ApplicationContext context)
        {
            _db = context;
        }

        #endregion

        #region index & paging

        public IActionResult Index()
        {
            return View(_db.ArticleModels);
        }

        #endregion

        #region Creat Article

        public IActionResult Creat()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
          public async Task<IActionResult> Creat(CreateArticleViewModel createArticleVM)
            {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                var article = _db.ArticleModels.Any(a => a.Title == createArticleVM.Title);
                if (!article)
                {
                    var newArticle = new ArticleModel()
                    {
                        Title = createArticleVM.Title,
                        Description = createArticleVM.Description,
                        TimeRead = createArticleVM.TimeRead,
                        CreateTime = DateTime.Now,
                        UserId = Convert.ToInt32(userid)
                    };
                    if (createArticleVM.Image != null)
                    {
                        string ImageName = Guid.NewGuid().ToString("N") +
                                           Path.GetExtension(createArticleVM.Image.FileName);
                        createArticleVM.Image.AddImageToServer(ImageName,
                            PathTools.ArticleImageServerPath, 75, 75, PathTools.ArticleImageThumbnailServerPath);
                        createArticleVM.ImageName = ImageName;
                    }
                    else
                    {
                        createArticleVM.ImageName = "article.png";
                    }

                    newArticle.Image = createArticleVM.ImageName;
                    _db.ArticleModels.Add(newArticle);
                    await _db.SaveChangesAsync();
                }
                else
                {
                    TempData["Error Article"] = "This Article Title Exist";
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }

        #endregion

        #region Detail

        public IActionResult Detail(int id)
        {
            var existArticle = _db.ArticleModels.SingleOrDefault(a => a.ArticleId == id);
            if (existArticle == null) return NotFound();
            return View(existArticle);
        }


        #endregion

        #region Edit

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var existArticle = _db.ArticleModels.SingleOrDefault(a => a.ArticleId == Id);
            if (existArticle == null) return NotFound();
            return View(existArticle);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditArticleVm editArticleVm)
        {
            var existArticle = _db.ArticleModels.SingleOrDefault(a => a.ArticleId == id);
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (existArticle == null) return NotFound();
            if (ModelState.IsValid)
            {
                existArticle.Title = editArticleVm.Title;
                existArticle.Description = editArticleVm.Description;
                existArticle.TimeRead = editArticleVm.TimeRead;
                existArticle.UserId = Convert.ToInt32(userid);
                existArticle.CreateTime = DateTime.Now;
                string ImageName = Guid.NewGuid().ToString("N")
                                   + Path.GetExtension(editArticleVm.Image.FileName);
                if (ImageName != existArticle.Image)
                {
                    editArticleVm.Image.AddImageToServer(ImageName,
                        PathTools.ArticleImageServerPath, 75, 75, PathTools.ArticleImageThumbnailServerPath,
                        editArticleVm.ImageName);
                    editArticleVm.ImageName = ImageName;
                }

                _db.ArticleModels.Update(existArticle);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index", "Article", new { area = "Admin" });
            }

            return View();
        }

        #endregion

        #region Delete
        public  IActionResult Delete(int Id)
        {
            var existArticle = _db.ArticleModels.SingleOrDefault(a => a.ArticleId == Id);
            if (existArticle == null) return NotFound();
            _db.ArticleModels.Remove(existArticle);
            _db.SaveChanges();
            return RedirectToAction("Index", "Article", new { area = "Admin" });
        }
        #endregion
    }
}
