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
    public class IcerikController : Controller
    {
        SSSRepository db = new SSSRepository();
        FileUpload upload = new FileUpload();
        public IActionResult Index()
        {
            return View(db.GetirHepsi());
        }
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Ekle(SSS model)
        {
            if (ModelState.IsValid)
            {
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
        public IActionResult SoruSil(int id)
        {
            SSSRepository grp = new SSSRepository();
            var gor = grp.GetirIdile(id);
            gor.Durum = false;
            bool durum = grp.Sil(gor);
            if (durum)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
        }
        public IActionResult SSS()
        {
            return View(db.GetirHepsi());
        }
        public IActionResult SoruEkle()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SoruEkle(SSS model)
        {
            if (ModelState.IsValid)
            {
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
