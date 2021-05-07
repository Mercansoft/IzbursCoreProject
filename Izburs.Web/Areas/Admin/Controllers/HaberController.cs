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

namespace Izburs.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class HaberController : Controller
    {
        HaberRepository db = new HaberRepository();
        HaberKatRepository dbkat = new HaberKatRepository();
        YorumRepository yorumdb = new YorumRepository();
        FileUpload upload = new FileUpload();
        public IActionResult Index()
        {
            return View(db.Liste());
        }
        public IActionResult Ekle()
        {
            ViewBag.Kat = dbkat.GetirHepsi();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Ekle(Haber model, IFormFile Resim)
        {
            ViewBag.Kat = dbkat.GetirHepsi();
            model.Resim = "s";
            model.Aciklama = "asd";
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
        public IActionResult Sil(int id)
        {
            var data = db.GetirIdile(id);
            bool durum = db.Sil(data);
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
        public IActionResult YorumSil(int id)
        {
            var data = yorumdb.GetirIdile(id);
            bool durum = yorumdb.Sil(data);
            if (durum)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
        }
        public IActionResult Yorumlar()
        {
            return View(yorumdb.Liste());
        }
        [HttpPost]
        public IActionResult Onayla(int id)
        {
            var data = yorumdb.GetirIdile(id);
            data.Durum = false;
            bool durum = yorumdb.Guncelle(data);
            if (durum)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
        }
        public IActionResult Duzenle(int id)
        {
            ViewBag.Kat = dbkat.GetirHepsi();
            return View(db.GetirHaberId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Duzenle(Haber model, IFormFile Resim)
        {
            if (ModelState.IsValid)
            {
                if (Resim != null)
                {
                    var result = upload._fncResimYukleAsync(Resim);
                    model.Resim = result.Result;
                }
                model.GuncellemeTarihi = Convert.ToDateTime(DateTime.Now);
                db.Guncelle(model);
            }
            ViewBag.Kat = dbkat.GetirHepsi();
            return View(model);
        }
    }
}
