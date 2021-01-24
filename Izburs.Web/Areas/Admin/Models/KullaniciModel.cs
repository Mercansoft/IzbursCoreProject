using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Areas.Admin.Models
{
    public class KullaniciModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Boş Geçilemez")]
        public string KullaniciAd { get; set; }
        [Required(ErrorMessage = "Şifre Boş Geçilemez")]
        public string Sifre { get; set; }
        public bool BeniHatirla { get; set; }
    }
}
