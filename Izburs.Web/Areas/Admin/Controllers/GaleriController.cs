using Izburs.Business.Repositories.EF;
using Izburs.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Izburs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Izburs.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class GaleriController : Controller
    {
        GaleriRepository db = new GaleriRepository();
        GaleriKatRepository dbkat = new GaleriKatRepository();
        FileUpload upload = new FileUpload();
        private IHostingEnvironment _env;
        public GaleriController(IHostingEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            return View(dbkat.GetirHepsi());
        }
        public IActionResult Goster(int id)
        {
            return View(db.GetirKatId(id));
        }
        public IActionResult Ekle()
        {
            ViewBag.Kat = dbkat.GetirHepsi();
            return View();
        }
        public IActionResult Kategori()
        {
            return View();
        }
        public IActionResult Sil(int id)
        {
            
       
            var galeri = db.GetirIdile(id);
            if (db.Sil(galeri))
            {
                string webRoot = _env.WebRootPath;
                string filePath = webRoot + galeri.Resim;
                Dosya.DosyaSil(filePath);
            }
            return Redirect("/Admin/Galeri/Goster/" + galeri.GaleriKatId.ToString());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Ekle(Galeri model, IFormFile Resim)
        {
            ViewBag.Kat = dbkat.GetirHepsi();
            model.Resim = "s";
            if (ModelState.IsValid)
            {
                var result = upload._fncResimYukleAsync(Resim);
                model.Resim = result.Result;
                model.GuncellemeTarihi= Convert.ToDateTime(DateTime.Now);
                model.KayitTarihi = Convert.ToDateTime(DateTime.Now);
               bool durum = db.Ekle(model);
                if (durum)
                {
                    ViewBag.Durum = "Başarıyla Eklendi.";
                }
                else
                {
                    ViewBag.Durum = "Hata.";

                }
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult KatEkle(GaleriKat model, IFormFile Resim)
        {
            model.Resim = "s";
            if (ModelState.IsValid)
            {
                var result = upload._fncResimYukleAsync(Resim);
                model.Resim = result.Result;
                model.GuncellemeTarihi = Convert.ToDateTime(DateTime.Now);
                model.KayitTarihi = Convert.ToDateTime(DateTime.Now);
                bool durum = dbkat.Ekle(model);
                if (durum)
                {
                    ViewBag.Durum = "Başarıyla Eklendi.";
                }
                else
                {
                    ViewBag.Durum = "Hata.";

                }
            }
            return RedirectToAction("Kategori", "Galeri", model);
        }
    }
}
