using Izburs.Business.Repositories.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.ViewComponents
{
    public class SSS : ViewComponent
    {
        public SSS()
        {

        }
        public IViewComponentResult Invoke()
        {
            SSSRepository hrp = new SSSRepository();
            return View(hrp.GetirHepsi());
        }
    }
}
