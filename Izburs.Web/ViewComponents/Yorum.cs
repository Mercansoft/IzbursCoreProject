using Izburs.Business.Repositories.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.ViewComponents
{
    public class Yorum : ViewComponent
    {
        public Yorum()
        {

        }
        public IViewComponentResult Invoke(int id)
        {
            YorumRepository grp = new YorumRepository();
            //return View(grp.Select(null).OrderByDescending(x=>x.Id).Take(12).ToList());
            return View(grp.listHaberId(id));
        }
    }
}
