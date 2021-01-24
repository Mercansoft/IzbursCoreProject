using Izburs.DAL.Entities;
using Izburs.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public HomeController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Admin/Giris")]
        public IActionResult Giris()
        {
            return View();
            //return View(new KullaniciModel());
        }
        [Route("/Admin/Giris")]
        [HttpPost]
        public IActionResult Giris(KullaniciModel model)
        {
            if (ModelState.IsValid)
            {
                var SignInResult=_signInManager.PasswordSignInAsync(model.KullaniciAd, model.Sifre, model.BeniHatirla, false).Result;
                if (SignInResult.Succeeded)
                {
                    //return RedirectToAction("Index", "Home");
                    return Redirect("/Admin/");
                    //return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
            }
            return View();
        }
        //[Route("/Admin/Cikis")]
        //public IActionResult Cikis()
        //{
        //    User.
        //    return RedirectToAction("Index", "Home", new { area = "Admin" });
        //}
        [Route("/Admin/Cikis")]
        public async Task<IActionResult> Cikis()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { area = "Admin" });
        }
    }
}
