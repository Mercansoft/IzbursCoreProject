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
            return View();
        }
    }
}
