using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    public class BaseEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
        public DateTime GuncellemeTarihi { get; set; } = DateTime.Now;
        public bool Durum { get; set; } = true;
    }
}
