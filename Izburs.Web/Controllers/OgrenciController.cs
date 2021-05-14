using Izburs.Business.Repositories.EF;
using Izburs.DAL.Entities;
using Izburs.Services;
using Izburs.Web.Areas.Admin.Models;
using Izburs.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Controllers
{
    [Authorize(Roles ="Öğrenci")]
    public class OgrenciController : Controller
    {
        GorusRepository grp = new GorusRepository();
        TranskriptRepository trp = new TranskriptRepository();
        DonemRepository ddb = new DonemRepository();
        BasvuruRepository _basvuru = new BasvuruRepository();
        FileUpload upload = new FileUpload();
        AppUserRepository app = new AppUserRepository();
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public OgrenciController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [Route("/Ogrenci/Giris")]
        public IActionResult Giris()
        {
            return View();
        }
        [AllowAnonymous]
        [Route("/Ogrenci/Giris")]
        [HttpPost]
        public IActionResult Giris(KullaniciModel model)
        {
            if (ModelState.IsValid)
            {
                var SignInResult = _signInManager.PasswordSignInAsync(model.KullaniciAd, model.Sifre, model.BeniHatirla, false).Result;
                if (SignInResult.Succeeded)
                {
                    //return RedirectToAction("Index", "Home");
                    return Redirect("/Ogrenci/");
                    //return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                ModelState.AddModelError("", "E-mail Adresiniz veya Şifre Hatalı");
            }
            return View();
        }
        public IActionResult Profil(string id)
        {
            var prof = _userManager.FindByNameAsync(id).Result;
            return View(prof);
        }
        [HttpPost]
        public IActionResult SifreDegistir(string YeniSifre)
        {
            var user =  _userManager.FindByNameAsync(User.Identity.Name).Result;

             var token =  _userManager.GeneratePasswordResetTokenAsync(user);

            var result =  _userManager.ResetPasswordAsync(user, token.Result, YeniSifre).Result;

            //var prof = _userManager.FindByNameAsync(User.Identity.Name).Result;
           //var token=  _userManager.GeneratePasswordResetTokenAsync(prof).Result;
            //var durum=_userManager.ResetPasswordAsync(prof, token.ToString(), password).Result;
            if (result.Succeeded==true)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
        }
        //public IActionResult Cikis()
        //{
        //    _signInManager
        //    return Redirect("/Ogrenci/");
        //}
        [HttpPost]
        public IActionResult BankaGuncelle(string BankaAdi,string Iban)
        {
            var usr = _userManager.FindByNameAsync(User.Identity.Name).Result;
            usr.BankaAdi = BankaAdi;
            usr.Iban = Iban;
            bool durum = app.Guncelle(usr);
            if (durum == true)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
        }
        [HttpPost]
        public IActionResult ProfilGuncelle(AppUser au, IFormFile Resim)
        {
            var result = upload._fncResimYukleAsync(Resim);
            var usr = _userManager.FindByNameAsync(User.Identity.Name).Result;
            usr.Resim = result.Result;
            usr.AdSoyad = au.AdSoyad;
            usr.DogumTarihi = au.DogumTarihi;
            usr.PhoneNumber = au.PhoneNumber;
            bool durum = app.Guncelle(usr);
            if (durum)
            {
                TempData["Durum"] = "<div class='alert alert-success'>Tebrikler! Bilgileriniz Başarıyla Güncellenmiştir.</div>";
            }
            else
            {
                TempData["Durum"] = "<div class='alert alert-danger'>Hata! Güncelleme Başarısız oldu.</div>";
            }
            return Redirect("/Ogrenci/Profil/" + User.Identity.Name);
        }
        [Route("/Ogrenci/Cikis")]
        public async Task<IActionResult> Cikis()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Basvurularim()
        {
            UserBasvuruViewModel model = new UserBasvuruViewModel();
            var usr = _userManager.FindByNameAsync(User.Identity.Name).Result;
            ViewBag.AdSoyad = usr.AdSoyad;
            ViewBag.Resim = usr.Resim;
            var data = _basvuru.Liste(usr.TcNo);
            model.User = usr;
            model.Basvurular = data;
            return View(model);
        }
        [HttpPost]
        public IActionResult TranskriptEkle(Transkript model,IFormFile file)
        {
            var usr = _userManager.FindByNameAsync(User.Identity.Name).Result;
            if (!ModelState.IsValid)
            {
                var result = upload._fncResimYukleAsync(file);
                var donems = ddb.GetirHepsi();
                Donem donm = donems.OrderByDescending(x => x.Id).FirstOrDefault();
                model.DonemId = donm.Id;
    
                model.AppUserId = usr.Id;
                model.Dosya = result.Result;
                trp.Ekle(model);
                TempData["Kayit"] = "Kayit Başarıyla Yapıldı.";
                return RedirectToAction("Transkriptlerim", "Ogrenci", trp.Liste(usr.Id));
            }
            else
            {
                TempData["Durum"] = "Farklı bir Formatta yükleme yaptınız Lütfen JPG ve PNG formatında yükleme yapınız";
                return RedirectToAction("Transkriptlerim", "Ogrenci", trp.Liste(usr.Id));
            }

        }
        public IActionResult Transkriptlerim()
        {
            var usr = _userManager.FindByNameAsync(User.Identity.Name).Result;
            //CookieOptions cookie = new CookieOptions();
            //cookie.Expires = DateTime.Now.AddYears(10);
            //Response.Cookies.Append("AdSoyad",usr.AdSoyad, cookie);
            ViewBag.AdSoyad = usr.AdSoyad;
            ViewBag.Resim = usr.Resim;
            return View(trp.Liste(usr.Id));
        }
        public IActionResult Goruslerim()
        {
            var usr = _userManager.FindByNameAsync(User.Identity.Name).Result;
            ViewBag.AdSoyad = usr.AdSoyad;
            ViewBag.Resim = usr.Resim;
            return View(grp.Liste(usr.Id));
        }
        [HttpPost]
        public IActionResult GorusEkle(Gorus model)
        {
            var usr = _userManager.FindByNameAsync(User.Identity.Name).Result;
            model.AppUserId = usr.Id;
            if (ModelState.IsValid)
            {
                grp.Ekle(model);
                TempData["Kayit"] = "Kayit Başarıyla Yapıldı.";
                return RedirectToAction("Goruslerim", "Ogrenci", grp.Liste(usr.Id));
            }
            else
            {
                TempData["Durum"] = "Lütfen Boş Geçmeyiniz";
                return RedirectToAction("Goruslerim", "Ogrenci", grp.Liste(usr.Id));
            }

        }
        [AllowAnonymous]
        public IActionResult SifremiUnuttum()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult SifremiUnuttum(string KullaniciAd)
        {

            bool durum = false;
            var usr = _userManager.FindByNameAsync(KullaniciAd).Result;

            if (usr!=null)
            {
           
                var token = _userManager.GeneratePasswordResetTokenAsync(usr);
                string uid = usr.Id;
                durum = MailGonder.SifremiUnuttumTemplate(usr.AdSoyad, usr.Email, "izburs.com/Ogrenci/Sifirla?ogrencitoken=" + token.Result + "&uid=" + uid, usr.Email);
              // durum = MailGonder.Gonder("Izburs Giriş Şifre Sıfırlama", "Şifrenizi SIfırlamak için aşağıdaki linki tıklayınız.<br><br><a href='izburs.com/Ogrenci/Sifirla?ogrencitoken="+token.Result+"&uid="+ uid + "'>ŞİFREMİ SIFIRLA</a>",usr.Email);
            }

            if (durum == true)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
        }
        [AllowAnonymous]
        public IActionResult Sifirla(string ogrencitoken, string uid)
        {
            TempData["token"] = ogrencitoken;
            TempData["uid"] = uid;
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult YeniSifre(string YeniSifre)
        {
            string uid = TempData["uid"].ToString();
            string token= TempData["token"].ToString();
            var user = _userManager.FindByIdAsync(uid).Result;
            var result = _userManager.ResetPasswordAsync(user, token, YeniSifre).Result;
            if (result.Succeeded == true)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
        }
    }
}
