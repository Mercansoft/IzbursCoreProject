using Izburs.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Izburs.Business.Tuple
{
    public class BasvuruViewModel
    {
        public IEnumerable<Sehir> Sehir { get; set; }
        public IEnumerable<Okul> Okul { get; set; }
        public IEnumerable<Bolum> Bolum { get; set; }
        public IEnumerable<Meslek> Meslek { get; set; }
        public IEnumerable<OkulTuru> OkulTuru { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
