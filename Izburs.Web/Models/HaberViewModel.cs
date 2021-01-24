using Izburs.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Izburs.Web.Models
{
    public class HaberViewModel
    {
        public IEnumerable<HaberKat> HaberKat { get; set; }
        public Haber Haber { get; set; }
    }
}
