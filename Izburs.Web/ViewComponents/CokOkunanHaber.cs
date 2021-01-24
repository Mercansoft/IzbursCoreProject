using Izburs.Business.Repositories.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.ViewComponents
{
    public class CokOkunanHaber : ViewComponent
    {
        public CokOkunanHaber()
        {

        }
        public IViewComponentResult Invoke()
        {
            HaberRepository grp = new HaberRepository();
            var haber = grp.CokOkunanHaber(5);
            //return View(grp.Select(null).OrderByDescending(x=>x.Id).Take(12).ToList());
            return View(haber);
        }
    }
}
