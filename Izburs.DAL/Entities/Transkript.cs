using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Transkript")]
    public class Transkript:BaseEntity
    {

        [Required(ErrorMessage = "Lütfen Transkriptinizi Boş Geçmeyiniz")]
        public string Dosya { get; set; }
        public string Aciklama { get; set; }
        public int KullaniciId { get; set; }
        public int DonemId { get; set; }
        public Donem Donem { get; set; }
    }
}
