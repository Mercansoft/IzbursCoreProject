using Izburs.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Izburs.Business.Tuple
{
    public class ProfilViewModel
    {
        public AppUser User { get; set; }
        public IEnumerable<OgrenciBasvuru> Basvurular { get; set; }
        public IEnumerable<Transkript> Transkript { get; set; }
    }
}
