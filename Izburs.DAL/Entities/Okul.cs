using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Okul")]
    public class Okul:BaseEntity
    {
        [MaxLength(250)]
        public string Ad { get; set; }

        public virtual List<Kullanici> Kullanicilar { get; set; }
    }
}
