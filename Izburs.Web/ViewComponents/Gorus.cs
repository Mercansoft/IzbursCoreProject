using Izburs.Business.Repositories.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.ViewComponents
{
    public class Gorus : ViewComponent
    {
        public Gorus()
        {

        }
        public IViewComponentResult Invoke()
        {
            GorusRepository grp = new GorusRepository();
            return View(grp.liste_soneklenen(10,false));
           // return View(grp.Select(x=>x.Durum==true).OrderByDescending(x=>x.Id).Take(10));
        }
    }
}
