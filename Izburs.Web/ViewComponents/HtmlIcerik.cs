using Izburs.Business.Repositories.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.ViewComponents
{
    public class HtmlIcerik: ViewComponent
    {
        public HtmlIcerik()
        {

        }
        public IViewComponentResult Invoke()
        {
            AyarRepository arp = new AyarRepository();
            var ayar=arp.Getir();
            ViewBag.Html = ayar.Html;
            return View();
        }
    }
}
