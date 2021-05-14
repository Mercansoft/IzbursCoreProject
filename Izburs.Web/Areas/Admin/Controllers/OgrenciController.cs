using Izburs.Business.Enum;
using Izburs.Business.Repositories.EF;
using Izburs.Business.Tuple;
using Izburs.DAL.Entities;
using Izburs.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class OgrenciController : Controller
    {
        BasvuruRepository brp = new BasvuruRepository();
        UserManager<AppUser> _userManager;
        RoleManager<IdentityRole> _roleManager;
        public OgrenciController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }
       // [Route("/Admin/Ogrenci/Basvuru")]
        public IActionResult Basvuru()
        {
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.Basvuru));
        }
        public IActionResult Burslu()
        {
            
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.Basarili));
        }
        public IActionResult BursuKesilen()
        {
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.Basarisiz));
        }
        public IActionResult Mezun()
        {
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.MezunOldu));
        }
        public IActionResult Inceleme()
        {
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.Inceleme));
        }
        public IActionResult Kararsiz()
        {
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.Kararsiz));
        }
        public IActionResult Olumlu()
        {
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.Olumlu));
        }
        public IActionResult Profil(int id)
        {
            OgrenciBasvuruRepository orp = new OgrenciBasvuruRepository();
            TranskriptRepository trp = new TranskriptRepository();
            ProfilViewModel model = new ProfilViewModel();
            var app = orp.GetirBasvuruId(id);
            model.User = _userManager.FindByIdAsync(app.AppUserId).Result;
            model.Transkript = trp.Liste(app.AppUserId);
            //model.User= _userManager.FindByNameAsync(name).Result;
            model.Basvurular = orp.GetirAppUserId(model.User.Id);
            return View(model);
        }
        public IActionResult Gorus()
        {
            GorusRepository grp = new GorusRepository();
            //return View(brp.GetirHepsi());
            return View(grp.Liste());
        }
        public IActionResult Goruntule(int id)
        {
            return View(brp.GetirID(id));
        }
        [HttpPost]
        public IActionResult DurumGuncelle(string Id,string durumId)
        {
            var bas = brp.GetirIdile(Convert.ToInt32(Id));
            bas.BursDurumID = Convert.ToInt32(durumId);
            bool durum= brp.Guncelle(bas);
            if (durum)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }

        }
        [HttpPost]
        public IActionResult GorusOnayla(int id)
        {
            GorusRepository grp = new GorusRepository();
            var gor = grp.GetirIdile(id);
            gor.Durum = false;
            bool durum = grp.Guncelle(gor);
            if (durum)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
        }
        [HttpPost]
        public IActionResult IzbursGiris(string Id, string durumId)
        {
            OgrenciBasvuruRepository obrp = new OgrenciBasvuruRepository();

            var basvuru = brp.GetirID(Convert.ToInt32(Id));
            AppUser ogrenci = new AppUser();
            ogrenci.AdSoyad = basvuru.Ad + " " + basvuru.Soyad;
            ogrenci.Bolum = basvuru.Bolum.Ad;
            ogrenci.DogumTarihi = Convert.ToDateTime(basvuru.DogumTarihi);
            ogrenci.Email = basvuru.Email;
            ogrenci.Okul = basvuru.Okul.Ad;
            ogrenci.OkulTuru = basvuru.OkulTuru.Ad;
            ogrenci.PhoneNumber = basvuru.Telefon;
            ogrenci.Resim = basvuru.Resim;
            ogrenci.Sinif = basvuru.Sinif;
            ogrenci.TcNo = basvuru.TcKimlikNo;
            ogrenci.UserName = basvuru.Email;
            AppUser createOgrenci = IdentityCreate.OlusturOgrenci(_userManager, _roleManager, ogrenci, basvuru.TcKimlikNo);
            //Task.Delay(2000);
            
            //var createOgrenci = _userManager.FindByNameAsync(basvuru.Email).Result;
            OgrenciBasvuru Basogrenci = new OgrenciBasvuru();
            Basogrenci.BasvuruId = Convert.ToInt32(Id);
            Basogrenci.AppUserId = createOgrenci.Id;
            bool durum = obrp.Ekle(Basogrenci);
            if (durum)
            {
                MailGonder.HosgeldinTemplate(createOgrenci.AdSoyad, createOgrenci.Email);
                MailGonder.PasswordTemplate(createOgrenci.Email);
                //MailGonder.Gonder("Tebrikler!", "İzburslu oldunuz", ogrenci.Email);
                var bas = brp.GetirIdile(Convert.ToInt32(Id));
                bas.BursDurumID = Convert.ToInt32(durumId);
                brp.Guncelle(bas);
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
        }
    }
}
