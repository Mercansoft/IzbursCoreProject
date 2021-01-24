using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Gorus")]
    public class Gorus:BaseEntity
    {
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public string Aciklama { get; set; }
    }
}
