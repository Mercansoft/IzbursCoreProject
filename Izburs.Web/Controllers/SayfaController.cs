using Izburs.Business.Repositories.EF;
using Izburs.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Controllers
{
    public class SayfaController : Controller
    {
        SayfaRepository srp = new SayfaRepository();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Oku(int id)
        {
            Sayfa model = srp.GetirIdile(id);
            try
            {
                if (model==null)
                {
                    return Redirect("/Hata/");
                }
                else
                {
                    return View(model);
                }
            }
            catch (Exception)
            {

                return Redirect("/Hata/");
            }
        }
    }
}
