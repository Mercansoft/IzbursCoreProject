using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("HaberKat")]
    public class HaberKat : BaseEntity
    {
        public string Ad { get; set; }

        public List<Haber> Haberler { get; set; }
    }
}
