using Izburs.Business.Repositories.EF;
using Izburs.DAL.Entities;
using Izburs.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        public HomeController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            BasvuruRepository brp = new BasvuruRepository();
            DonemRepository drp = new DonemRepository();
            var data = brp.Liste();
            int mezun = data.Where(X => X.BursDurumID == 5).ToList().Count;
            int basarili = data.Where(X => X.BursDurumID == 2).ToList().Count;
            ViewBag.ToplamVerilenBurs = (mezun + basarili).ToString();
            var donem = drp.SonDonem();
            ViewBag.BuyilBurslu = data.Where(x => x.DonemID == donem.Id&&x.BursDurumID==2).ToList().Count;
            ViewBag.BuyilBasvuru = data.Where(x => x.DonemID == donem.Id).ToList().Count;
            ViewBag.Toplam = data.ToList().Count;
            return View();
        }
        //public IActionResult Giris()
        //{
        //    return View(new KullaniciModel());
        //}
        //[HttpPost]
        //public IActionResult Giris(KullaniciModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var signResult= _signInManager.PasswordSignInAsync(model.KullaniciAd, model.Sifre, model.BeniHatirla, false).Result;
        //        if (signResult.Succeeded)
        //        {
        //            return RedirectToAction("Index", "Admin", new { area = "Admin" });
        //        }
        //        ModelState.AddModelError("","Kullanıcı Adı veya Şifre Hatalı");
        //    }
        //    return View(model);
        //}
        [Route("/Account/AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
