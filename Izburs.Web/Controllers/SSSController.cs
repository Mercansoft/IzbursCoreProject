using Izburs.Business.Repositories.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Controllers
{
    public class SSSController : Controller
    {
        SSSRepository db = new SSSRepository();
        public IActionResult Index()
        {
            return View(db.GetirHepsi());
        }
    }
}
