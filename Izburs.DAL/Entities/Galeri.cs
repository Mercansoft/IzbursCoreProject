using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Galeri")]
    public class Galeri:BaseEntity
    {
        public int GaleriKatId { get; set; }
        public GaleriKat GaleriKat { get; set; }
        public string Resim { get; set; }
    }
}
