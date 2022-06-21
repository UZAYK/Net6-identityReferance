using KUSYSDemo.Entities.Concrete;
using KUSYSDemo.Models.AppUserDto;
using KUSYSDemo.Web.BaseController;
using KusysProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KusysProject.Controllers
{
    public class HomeController : BaseIdentityController
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) : base(userManager)
        {
            _signInManager = signInManager;
        }

        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        public IActionResult Giris()
        {
            return View();
        }

        #region Giriş Yap
        [HttpPost]
        public async Task<IActionResult> GirisYap(AppUserSignInDto model)
        {
            TempData["Active"] = "cikis";

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    var identityResult = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                    if (identityResult.Succeeded)
                    {
                        var roller = await _userManager.GetRolesAsync(user);
                        if (roller.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home", new { area = "Dealer" });
                        }
                    }
                }
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
            }
            return View("Index", model);
        }
        #endregion

        #region Kayıt Ol
        public IActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> KayitOl(AppUserAddDto model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var addRoleResult = await _userManager.AddToRoleAsync(user, "Dealer");
                    if (addRoleResult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    HataEkle(addRoleResult.Errors);
                }
                HataEkle(result.Errors);
            }
            return View(model);
        }
        #endregion

        #region Çıkış Yap
        public async Task<IActionResult> CikisYap()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        #endregion

        public IActionResult StatusCode(int? code)
        {
            if (code == 404)
            {
                ViewBag.Code = code;
                ViewBag.Message = "Sayfa Bulunmadı";
            }

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}