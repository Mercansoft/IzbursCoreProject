using Izburs.Business.Repositories.EF;
using Izburs.Business.Tuple;
using Izburs.DAL.Entities;
using Izburs.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Controllers
{
    public class BasvuruController : Controller
    {
        UserManager<AppUser> userManager;
        RoleManager<IdentityRole> roleManager;
        ////string TamYolYeri = "";
        //private readonly IHostingEnvironment _environment;
        //public BasvuruController(IHostingEnvironment environment) { _environment = environment; }
        public BasvuruController(UserManager<AppUser> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            roleManager = _roleManager;
        }
        public BasvuruViewModel GetData()
        {
            BasvuruViewModel model = new BasvuruViewModel();
            BolumRepository rpBolum = new BolumRepository();
            SehirRepository rpSehir = new SehirRepository();
            OkulRepository rpOkul = new OkulRepository();
            MeslekRepository rpMeslek = new MeslekRepository();
            OkulTuruRepository rpOkulT = new OkulTuruRepository();
            model.OkulTuru = rpOkulT.GetirHepsi();
            model.Meslek = rpMeslek.GetirHepsi();
            model.Okul = rpOkul.GetirHepsi();
            model.Sehir = rpSehir.GetirHepsi();
            model.Bolum = rpBolum.GetirHepsi();
            return model;
        }
        public IActionResult Index()
        {

            return View(GetData());
        }
        private bool OgrenciOlustur(string email,string adsoyad,string tel,DateTime dogumtarih,string resim)
        {

            try
            {
                AppUser user = new AppUser
                {
                    UserName = email,
                    AdSoyad = adsoyad,
                    Email = email,
                    PhoneNumber = tel,
                    BankaAdi = "",
                    DogumTarihi = Convert.ToDateTime(dogumtarih),
                    Iban = "",
                    Resim = resim
                };
                if (userManager.FindByNameAsync(email).Result == null)
                {
                    var identityResult = userManager.CreateAsync(user, SifreOlustur.SifreUret(6,false)).Result;
                }
                if (roleManager.FindByNameAsync(email).Result == null)
                {
                    IdentityRole role = new IdentityRole
                    {
                        Name = "Öğrenci"
                    };
                    var varmi = roleManager.RoleExistsAsync(role.Name.ToString());
                    if (!varmi.Result)
                    {
                        var IdentityResult = roleManager.CreateAsync(role).Result;
                    }
                    var result = userManager.AddToRoleAsync(user, role.Name);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Basvuru model, IFormCollection form, IFormFile Resim)
        {
            OgrenciBasvuruRepository ogbasdb = new OgrenciBasvuruRepository();
            BasvuruRepository kdb = new BasvuruRepository();
            DonemRepository ddb = new DonemRepository();

            var donems = ddb.GetirHepsi();
            Donem donm = donems.OrderByDescending(x => x.Id).FirstOrDefault();
            model.DonemID = donm.Id;


            var veri = _fncResimYukleAsync(Resim);
            //var veri = _fncResimYukle(Resim);
            model.Resim = veri.Result;

            if (!ModelState.IsValid)
            {
                try
                {
                    if (form["AnneSag"].ToString() == "Evet")
                    {
                        model.AnneSag = true;
                    }
                    if (form["BabaSag"].ToString() == "Evet")
                    {
                        model.BabaSag = true;
                    }
                    if (form["AnneBabaBirlikte"].ToString() == "Evet")
                    {
                        model.AnneBabaBirlikte = true;
                    }
                    if (form["EvKirami"].ToString() == "Kira")
                    {
                        model.EvKirami = true;
                    }
                    if (form["BaskaBurs"].ToString() == "Evet")
                    {
                        model.BaskaBurs = true;
                    }
                }
                catch (Exception)
                {

                }
                int puan = 0;
                string hata = string.Empty;
                //model.Sifre = "123456Aa";
                model.BankaAdi = "Banka Adını Yazınız";
                model.HesapNo = "Hesap Numaranızı Yazınız";
                model.Iban = "IBAN Numaranızı Yazınız";
                model.BursDurumID = 1;
                model.KayitTarihi = Convert.ToDateTime(DateTime.Now);
                model.GuncellemeTarihi = Convert.ToDateTime(DateTime.Now);
                if (model.OkulTuruId == 1)
                {
                    puan += 5;
                }
                if (model.Gelir.ToString().Length > 2)
                {
                    if (model.Gelir <= 800)
                    { puan += 40; }
                    else if (model.Gelir >= 801 || model.Gelir <= 1500)
                    { puan += 35; }
                    else if (model.Gelir >= 1501 || model.Gelir <= 2500)
                    { puan += 25; }
                    else { puan += 5; }
                }
                if (model.AnneSag == false && model.BabaSag == false)
                {

                    puan += 50;
                }
                else
                {

                    if (model.AnneSag == true)
                    {
                        //model.AnneSag = true;
                        //int AnneMeslek = Convert.ToInt32(form["MeslekID"]);
                        //model.AnneMeslekID = AnneMeslek;
                        switch (model.AnneMeslekID)
                        {
                            case 1:
                                puan += 20;
                                break;
                            case 2:
                                puan += 15;
                                break;
                            case 3:
                                puan += 10;
                                break;
                            case 4:
                                puan += 5;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        model.AnneMeslekID = 1;
                        model.AnneSag = false;
                        puan += 20;
                    }


                    if (model.BabaSag == true)
                    {
                        //model.BabaSag = true;
                        //int BabaMeslek = Convert.ToInt32(form["MeslekID2"]);
                        //model.BabamMeslekID = BabaMeslek;
                        switch (model.BabamMeslekID)
                        {
                            case 1:
                                puan += 20;
                                break;
                            case 2:
                                puan += 15;
                                break;
                            case 3:
                                puan += 10;
                                break;
                            case 4:
                                puan += 5;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        model.BabamMeslekID = 1;
                        model.BabaSag = false;
                        puan += 25;
                    }
                    if (model.AnneSag == true && model.BabaSag == true)
                    {
                        if (model.AnneBabaBirlikte == false)
                        {
                            puan += 15;
                            // model.AnneBabaBirlikte = true;
                        }
                        //else
                        //{
                        //    model.AnneBabaBirlikte = false;
                        //    puan += 15;
                        //}
                    }
                    //else
                    //{
                    //    model.AnneBabaBirlikte = false;
                    //}

                }
                if (model.EvKirami == true)
                {
                    puan += 10;
                }
                try
                {
                    int sayi = model.KardesSayisi;
                    if (sayi >= 3)
                    {
                        puan += 10;
                    }
                    if (sayi == 2 || sayi == 1)
                    {
                        puan += 5;
                    }
                }
                catch (Exception)
                {

                }

                model.Aciklama = "...";
                model.Puan = puan;
                bool durum =kdb.Ekle(model);
                if (durum)
                {
                    AppUser ogrenci = userManager.FindByNameAsync(model.Email).Result;
                    if (ogrenci==null)
                    {
                        OgrenciOlustur(model.Email, model.Ad + " " + model.Soyad, model.Telefon, model.DogumTarihi, model.Resim);
                        AppUser ogrenci2 = userManager.FindByNameAsync(model.Email).Result;
                        OgrenciBasvuru ogrb = new OgrenciBasvuru
                        {
                            AppUserId = ogrenci2.Id,
                            BasvuruId = model.Id

                        };
                        ogbasdb.Ekle(ogrb);
                    }
                    else
                    {
                        
                        OgrenciBasvuru ogrb = new OgrenciBasvuru
                        {
                            AppUserId = ogrenci.Id,
                            BasvuruId = model.Id

                        };
                        ogbasdb.Ekle(ogrb);
                    }

                    return Redirect("/Basvuru/Durum");
                }
            }

            return View(GetData());
        }
        private async Task<string> _fncResimYukleAsync(IFormFile file)
        {
            // string DosyaAdi = Guid.NewGuid().ToString().Replace("-", "");
            // string uzanti = System.IO.Path.GetExtension(Dosya);
            // if (uzanti != "")
            // {
            //     TamYolYeri = "/Uploads/Ogrenci/" + DosyaAdi + uzanti;

            //     form.Files[0].SaveAs(Server.MapPath(TamYolYeri));
            //     form.Files[0].FileName
            // }
            // else
            // {
            //     TamYolYeri = Session["Resim"].ToString();
            // }
            //// return TamYolYeri;

            string path = "";
            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);

                string imageName = Guid.NewGuid() + imageExtension;

                path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Uploads/Ogrenci/{imageName}");
               // path = Path.Combine(Directory.GetCurrentDirectory(), "/Uploads/Ogrenci/" + imageName);

                using var stream = new FileStream(path, FileMode.Create);

                await file.CopyToAsync(stream);
                path = @"/Uploads/Ogrenci/" + imageName.ToString();
            }
            return path;
        }
        public IActionResult Durum()
        {
            return View();
        }
        //public async Task<IActionResult> _fncResimYukle(IFormFile Getfile)
        //{
        //    string fileName = Guid.NewGuid().ToString();
        //    if (Getfile != null)
        //    {
        //        var Upload = Path.Combine(_environment.WebRootPath, "/Uploads/Ogrenci/", fileName);
        //        Getfile.CopyTo(new FileStream(Upload, FileMode.Create));
        //    }
        //    return View();
        //}




        //private string _fncResimYukle(IFormCollection form)
        //{
        //    string TamYolYeri = "";
        //    string DosyaAdi = Guid.NewGuid().ToString().Replace("-", "");
        //    string uzanti = System.IO.Path.GetExtension(Dosya);
        //    if (uzanti != "")
        //    {
        //        TamYolYeri = "/Uploads/Ogrenci/" + DosyaAdi + uzanti;

        //        form.Files[0].SaveAs(Server.MapPath(TamYolYeri));
        //        form.Files[0].FileName
        //     }
        //    else
        //    {
        //        TamYolYeri = Session["Resim"].ToString();
        //    }
        //    return TamYolYeri;
        //}
    }
}
