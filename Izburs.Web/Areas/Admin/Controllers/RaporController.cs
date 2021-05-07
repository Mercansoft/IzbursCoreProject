using Izburs.Business.Repositories.EF;
using Izburs.Business.Tuple;
using Izburs.DAL.Entities;
using Izburs.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RaporController : Controller
    {
        BasvuruRepository db = new BasvuruRepository();
        OkulRepository okulrp = new OkulRepository();
        BolumRepository bolumrp = new BolumRepository();
        SehirRepository sehirrp = new SehirRepository();
        OkulTuruRepository okulturrp = new OkulTuruRepository();
        DonemRepository donemrp = new DonemRepository();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Basvuru()
        {


            //RaporViewModel model = new RaporViewModel();
            //model.Bolum = bolumrp.GetirHepsi();
            //model.Okul = okulrp.GetirHepsi();
            //model.OkulTuru = okulturrp.GetirHepsi();
            //model.Sehir = sehirrp.GetirHepsi();


            veri();
            var basvuru = new List<Basvuru>();
            return View(basvuru);
        }
        [HttpPost]
        public IActionResult Basvuru(RaporBasvuruModel model)
        {
            List<Basvuru> data = new List<Basvuru>();
            var donem = donemrp.SonDonem();
             data = db.ListeDonem(donem.Id);
            if (model.BolumId!=0)
            {
                data = data.Where(x => x.BolumId == model.BolumId).ToList();
            }
            if (model.OkulId!=0)
            {
                data = data.Where(x => x.OkulId == model.OkulId).ToList();
            }
            if (model.OkulTuruId != 0)
            {
                data = data.Where(x => x.OkulTuruId == model.OkulTuruId).ToList();
            }
            if (model.SehirId != 0)
            {
                data = data.Where(x => x.SehirId == model.SehirId).ToList();
            }
            veri();
            return View(data);
        }
        private void veri()
        {
            ViewBag.Bolum = bolumrp.GetirHepsi();
            ViewBag.Okul = okulrp.GetirHepsi();
            ViewBag.OkulTuru = okulturrp.GetirHepsi();
            ViewBag.Sehir = sehirrp.GetirHepsi();
        }
    }
}
