using Izburs.Business.Repositories.EF;
using Izburs.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Izburs.Web.Controllers
{
    //[Route("haber")]
    public class HaberController : Controller
    {
        HaberRepository hrp = new HaberRepository();
        YorumRepository yrp = new YorumRepository();
        public IActionResult Index()
        {
            return View(hrp.GetirKatId(1));
        }
        //[HttpGet("haber/{id}/{title}", Name = "Oku")]
        public IActionResult Oku(int id)
        {
            var haber = new Haber();
            try
            {
                haber = hrp.GetirHaberId(id);
               
                if (haber==null)
                {
                    return Redirect("/Hata/");

                }
                else
                {
                    haber.Hit += 1;
                    hrp.Guncelle(haber);
                    return this.View(haber);
                }
               
            }
            catch (System.Exception)
            {
                return Redirect("/Hata/");
            }
            //string friendlyTitle = FriendlyUrlHelper.GetFriendlyTitle(haber.Baslik);
            //if (!string.Equals(friendlyTitle, baslik, StringComparison.Ordinal))
            //{
            //    return this.RedirectToRoutePermanent("Oku", new { id = id, title = friendlyTitle });
            //}
        }
        [HttpPost]
        public IActionResult YorumGonder(Yorum model)
        {
            if (yrp.Ekle(model))
            {
                return Json("ok");
            }
            else
            {
                return Json("no");

            }
            
        }
        public IActionResult Etkinlik()
        {
            return View(hrp.GetirKatId(2));
        }
    }
}
