using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.ViewComponents
{
    public class Menu:ViewComponent
    {
        public Menu()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
