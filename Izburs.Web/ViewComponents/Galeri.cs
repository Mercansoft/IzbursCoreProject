using Izburs.Business.Repositories.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.ViewComponents
{
    
    public class Galeri : ViewComponent
    {
        public Galeri()
        {

        }
        public IViewComponentResult Invoke()
        {
            GaleriRepository grp = new GaleriRepository();
            //return View(grp.Select(null).OrderByDescending(x=>x.Id).Take(12).ToList());
            return View(grp.liste_soneklenen(12));
        }
    }
}
