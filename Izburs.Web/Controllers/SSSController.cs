﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Controllers
{
    public class SSSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
