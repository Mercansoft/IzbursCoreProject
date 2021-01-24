using Izburs.Business.Repositories.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.ViewComponents
{
    public class Haberler : ViewComponent
    {
        public Haberler()
        {

        }
        public IViewComponentResult Invoke()
        {
            HaberRepository hrp = new HaberRepository();
            return View(hrp.GetirHepsi());
        }
    }
}
