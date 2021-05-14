using Izburs.Business.Repositories.EF;
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
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        AyarRepository arp = new AyarRepository();
        BasvuruRepository brp = new BasvuruRepository();
        DonemRepository drp = new DonemRepository();
        //  private readonly RoleManager<AppUser> _RoleManager;
        public HomeController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            //_RoleManager = RoleManager;
        }
        public IActionResult Index()
        {
            var ayar = arp.GetirIdile(2);
            var donem = drp.SonDonem();
            var veri = brp.Liste();
            var basvurusay = veri.Where(x => x.DonemID == donem.Id).ToList();
            var burslu = veri.Where(x => x.BursDurumID == 2).ToList();
            var mezun = veri.Where(x => x.BursDurumID == 5).ToList();
            var basarisiz = veri.Where(x => x.BursDurumID == 4).ToList();
            ViewBag.BasvuruSayisi = basvurusay.Count.ToString();
            ViewBag.Burslu = burslu.Count.ToString();
            ViewBag.Mezun = mezun.Count.ToString();
            ViewBag.Basarisiz = basarisiz.Count.ToString();
            return View();
        }
        [AllowAnonymous]
        [Route("/Admin/Giris")]
        public IActionResult Giris()
        {
            return View();
            //return View(new KullaniciModel());
        }
        [AllowAnonymous]
        [Route("/Admin/Giris")]
        [HttpPost]
        public IActionResult Giris(KullaniciModel model)
        {
            if (ModelState.IsValid)
            {
                var SignInResult=_signInManager.PasswordSignInAsync(model.KullaniciAd, model.Sifre, model.BeniHatirla, false).Result;
                if (SignInResult.Succeeded)
                {
                    AppUser mod = _userManager.FindByNameAsync(model.KullaniciAd).Result;
                    if (_userManager.IsInRoleAsync(mod,"Öğrenci").Result)
                    {
                        return Redirect("/Ogrenci/");
                        //return RedirectToAction("Index", "Ogrenci");
                    }
                    else
                    {
                        //return RedirectToAction("Index", "Home");
                        //return Redirect("/Admin/");
                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                }
                //TempData["Durum"] = "Kullanıcı Adı veya Şifre Hatalı";
                //ViewBag.Durum = "Kullanıcı Adı veya Şifre Hatalı";
                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
            }
            return View(model);
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
        [HttpPost]
        public IActionResult BasvuruDurum()
        {
            AyarRepository arp = new AyarRepository();
            //var ayar = arp.GetirIdile(2);
            var ayar = arp.Getir();
            if (ayar.BasvuruForm)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
           
        }
        [HttpPost]
        public IActionResult BasvuruDurumDegistir()
        {
            AyarRepository arp = new AyarRepository();
            var ayar = arp.Getir();
            
            if (ayar.BasvuruForm)
            {
                ayar.BasvuruForm = false;
                arp.Guncelle(ayar);
                return Json("no");
            }
            else
            {
                ayar.BasvuruForm = true;
                arp.Guncelle(ayar);
                return Json("ok");
            }

        }
    }
}
