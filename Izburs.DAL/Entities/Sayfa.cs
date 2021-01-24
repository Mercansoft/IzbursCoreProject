using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Sayfa")]
    public class Sayfa : BaseEntity
    {
        //[Required(ErrorMessage = "Lütfen Resim Alanını Boş Geçmeyiniz")]
        public string Resim { get; set; }
        //[Required(ErrorMessage = "Lütfen Başlık Kısmın Boş Geçmeyiniz")]
        public string Baslik { get; set; }
        public string Icerik { get; set; }
    }
}
