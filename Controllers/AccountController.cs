using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using System.Security.Claims;
using Test.Context;
using Test.Models.User;
using Test.Utilities;
using Test.Utilities.IdentityHelper;
using Test.ViewModels.UserVM;
using WebApplication2.Utilities.ImageHelper;

namespace Test.Controllers
{
    public class AccountController : Controller
    {
        #region Injection Context DB

        private readonly ApplicationContext _db;
        public AccountController(ApplicationContext context)
        {
            _db = context;
        }

        #endregion

        #region Login
        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Title"] = "login";
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToRoute("/");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = _db.UserModels.SingleOrDefault(u => u.Email == loginVM.Email);
                if (user == null)
                {
                    ModelState.AddModelError("Email", "username or password is not true");
                    return View(loginVM);
                }
                if (user.Password != PasswordHelper.EncodePasswordMD5(loginVM.Password))
                {
                    ModelState.AddModelError("Email", "username or password is not true");
                    return View(loginVM);
                }
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                    new Claim(ClaimTypes.Email, loginVM.Email),
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                AuthenticationProperties authenticationProperties = new AuthenticationProperties()
                {
                    IsPersistent = loginVM.Remeberme
                };
                await HttpContext.SignInAsync(claimsPrincipal, authenticationProperties);
                return RedirectToAction("Index", "Home");
            }
            return View(loginVM);
        }
        #endregion

        #region Register
        [HttpGet]
        public IActionResult Register()
        {
            ViewData["Title"] = "Register";
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToRoute("/");
            }
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel registerVM)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToRoute("/");
            }
            if (ModelState.IsValid)
            {
                var user = _db.UserModels.SingleOrDefault(u => u.Email == registerVM.Email);
                if (user == null)
                {
                    var newUser = new UserModel()
                    {
                        Name = registerVM.Name,
                        Email = registerVM.Email,
                        Password = PasswordHelper.EncodePasswordMD5(registerVM.Password),
                        Phone = registerVM.Phone
                    };
                    if (registerVM.Profilimg != null)
                    {
                        string ImageName = Guid.NewGuid().ToString("N") + Path.GetExtension(registerVM.Profilimg.FileName);
                        registerVM.Profilimg.AddImageToServer(ImageName,
                            PathTools.ProfileImageServerPath, 75, 75, PathTools.ProfileImageThumbnailServerPath);
                        registerVM.ProfilimgName = ImageName;
                    }
                    else
                    {
                        string ImageName = "avatar.png";
                        registerVM.ProfilimgName = ImageName;
                    }
                    _db.UserModels.Add(newUser);
                    _db.SaveChanges();
                    TempData["SuccessMessage"] = "You have successfully registered";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Email", "user is exist");
                }
            }
            return View(registerVM);
        }
        #endregion

        #region Edit User
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            ViewData["Title"] = "Edit user";
            var ExistUser = _db.UserModels.SingleOrDefault(u => u.UserId == id);
            ViewData["TitleEdit"] = "Edit user" + ExistUser.Name;
            if (ExistUser == null) return NotFound();
            var user = new EditUserVM()
            {
                UserId = id,
                Name = ExistUser.Name,
                Email = ExistUser.Email,
                Password = ExistUser.Password,
                Phone = ExistUser.Phone,
                ProfilimgName = ExistUser.Profilimg
            };

            return View(user);
        }
        [HttpPost]
        public IActionResult EditUser(int id, EditUserVM editUserVM)
        {
            var ExistUser = _db.UserModels.SingleOrDefault(u => u.UserId == id);
            if (ExistUser == null) return NotFound();
            if (ModelState.IsValid)
            {
                ExistUser.Name = editUserVM.Name;
                ExistUser.Email = editUserVM.Email;
                ExistUser.Phone = editUserVM.Phone;
                ExistUser.Password = editUserVM.Password;
                string ImageName = Guid.NewGuid().ToString("N")
                                 + Path.GetExtension(editUserVM.Profilimg.FileName);
                if (ImageName != ExistUser.Profilimg)
                {
                    editUserVM.Profilimg.AddImageToServer(ImageName,
                              PathTools.ProfileImageServerPath, 75, 75, PathTools.ProfileImageThumbnailServerPath, ExistUser.Profilimg);
                    editUserVM.ProfilimgName = ImageName;
                }
                _db.UserModels.Update(ExistUser);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home",new {Area = "Users"});
            }

            return View();
        }
        #endregion

        #region Logout
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home"); 
        }
        #endregion
    }
}
