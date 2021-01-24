using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("GaleriKat")]
    public class GaleriKat:BaseEntity
    {
        public string Ad { get; set; }
        public string Resim { get; set; }
    }
}
