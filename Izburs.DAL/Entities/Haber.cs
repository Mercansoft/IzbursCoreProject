using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Haber")]
    public class Haber:BaseEntity
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Resim { get; set; }
        public int HaberKatId { get; set; }
        public HaberKat HaberKat { get; set; }
        public int Hit { get; set; }

        public virtual ICollection<Yorum> Yorumlar { get; set; }
    }
}
