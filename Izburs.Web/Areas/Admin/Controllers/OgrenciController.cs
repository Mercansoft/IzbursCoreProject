using Izburs.Business.Enum;
using Izburs.Business.Repositories.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       // [Route("/Admin/Ogrenci/Basvuru")]
        public IActionResult Basvuru()
        {
            BasvuruRepository brp = new BasvuruRepository();
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.Basvuru));
        }
        public IActionResult Burslu()
        {
            BasvuruRepository brp = new BasvuruRepository();
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.Basarili));
        }
        public IActionResult BursuKesilen()
        {
            BasvuruRepository brp = new BasvuruRepository();
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.Basarisiz));
        }
        public IActionResult Mezun()
        {
            BasvuruRepository brp = new BasvuruRepository();
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.MezunOldu));
        }
        public IActionResult Profil()
        {
            BasvuruRepository brp = new BasvuruRepository();
            //return View(brp.GetirHepsi());
            return View(brp.Liste((int)Sabitler.OgrenciDurum.MezunOldu));
        }
        public IActionResult Gorus()
        {
            GorusRepository grp = new GorusRepository();
            //return View(brp.GetirHepsi());
            return View(grp.Liste());
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
    }
}
