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
    public class SayfaController : Controller
    {
        SayfaRepository db = new SayfaRepository();
        FileUpload upload = new FileUpload();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Ekle(Sayfa model, IFormFile Resim)
        {
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
    }
}
