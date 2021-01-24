using Izburs.Business.Repositories.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Controllers
{
    public class GaleriController : Controller
    {
        public IActionResult Index()
        {
            GaleriKatRepository grp = new GaleriKatRepository();
            var kat = grp.GetirHepsi();
            return View(kat);
        }
        public IActionResult Goster(int id)
        {
            GaleriRepository grp = new GaleriRepository();
            var ad = grp.Select(x => x.GaleriKatId == id).ToList();
            var katt = ad.FirstOrDefault();
            ViewBag.KatAdi = katt.GaleriKat.Ad;
            return View(ad);
        }
    }
}
