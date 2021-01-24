using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class SharedController : Controller
    {
        public IActionResult _Layout()
        {
            return View();
        }
        public IActionResult _LayoutTablo()
        {
            return View();
        }
    }
}
