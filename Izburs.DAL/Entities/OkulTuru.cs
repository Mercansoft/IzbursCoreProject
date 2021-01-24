using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("OkulTuru")]
    public class OkulTuru:BaseEntity
    {
        public string Ad { get; set; }

        public virtual List<Kullanici> Kullanicilar { get; set; }
    }
}
