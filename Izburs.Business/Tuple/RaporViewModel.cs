using Izburs.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Izburs.Business.Tuple
{
    public class RaporViewModel
    {
        public List<Sehir> Sehir { get; set; }
        public List<Okul> Okul { get; set; }
        public List<Bolum> Bolum { get; set; }
        public List<OkulTuru> OkulTuru { get; set; }
        public List<Basvuru> Basvuru { get; set; }
    }
}
