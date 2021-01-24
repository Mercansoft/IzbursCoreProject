using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Donem")]
    public class Donem : BaseEntity
    {
        [MaxLength(250)]
        public string Ad { get; set; }

        public virtual List<Kullanici> Kullanicilar { get; set; }
        public virtual List<Transkript> Transkriptler { get; set; }
    }
}
