using Izburs.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Controllers
{
    public class IletisimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Gonder(string AdSoyad,string Email,string Konu,string Telefon,string Mesaj)
        {
            bool durum = false;
            string data = "Ad Soyad :" + AdSoyad + "<br>Email :" + Email + "<br>Telefon :" + Telefon + "<br>Mesaj :" + Mesaj;
            durum=MailGonder.Gonder(Konu, data,"info@izburs.com");
            if (durum==true)
            {
                return Json("ok");
            }
            else
            {
                return Json("no");
            }
            //return Redirect("/Iletisim/");
        }
    }
}
