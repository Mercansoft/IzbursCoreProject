using Izburs.Business.Repositories.EF;
using Izburs.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Izburs.Services;
using System;
using Microsoft.AspNetCore.Http;

namespace Izburs.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AyarController : Controller
    {
        AyarRepository db = new AyarRepository();
        FileUpload upload = new FileUpload();
        public IActionResult Index()
        {
            return View(db.GetirIdile(2));
        }
        public IActionResult HtmlGuncelle()
        {

            return View(db.GetirIdile(2));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult HtmlGuncelle(Ayar model)
        {
                model.GuncellemeTarihi = Convert.ToDateTime(DateTime.Now);
                db.Guncelle(model);
            return View(model);
        }
        //[HttpPost]
        //public IActionResult Sil(int id)
        //{
        //    var data = db.GetirIdile(id);
        //   bool durum= db.Sil(data);
        //    if (durum)
        //    {
        //        return Json("ok");
        //    }
        //    else
        //    {
        //        return Json("no");
        //    }
        //}
    }
}
