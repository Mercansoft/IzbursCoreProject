using Izburs.Business.Interfaces;
using Izburs.DAL.Contexts;
using Izburs.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Izburs.Business.Repositories.EF
{
    public class GaleriRepository : GenericRepository<Galeri>, IGaleriRepository
    {
        public List<Galeri> liste_soneklenen(int Adet)
        {
            using IzbursContext db = new IzbursContext();
            var galeri = db.Galeri.OrderByDescending(x => x.Id).Take(Adet).ToList();
            return galeri;
        }
        public List<Galeri> GetirKatId(int KatId)
        {
            using IzbursContext db = new IzbursContext();
            var galeri = db.Galeri.Where(x=>x.GaleriKatId==KatId).OrderByDescending(x => x.Id).ToList();
            return galeri;
        }
    }
}
