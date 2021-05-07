using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Ayar")]
    public class Ayar:BaseEntity
    {
        public string Html { get; set; }
        public bool BasvuruForm { get; set; }
    }
}
