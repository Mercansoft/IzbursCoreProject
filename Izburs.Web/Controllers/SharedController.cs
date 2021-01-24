using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult _Layout()
        {
            return View();
        }
    }
}
