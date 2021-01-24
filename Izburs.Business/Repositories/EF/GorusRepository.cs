using Izburs.Business.Interfaces;
using Izburs.DAL.Contexts;
using Izburs.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Izburs.Business.Repositories.EF
{
    public class GorusRepository : GenericRepository<Gorus>,IGorusRepository
    {
        public List<Gorus> liste_soneklenen(int Adet)
        {
            using IzbursContext db = new IzbursContext();
            var Gorus = db.Gorus.OrderByDescending(x => x.Id).Include(X => X.Kullanici).Include(X => X.Kullanici.Okul).Include(X => X.Kullanici.Bolum).Take(Adet).ToList();
            return Gorus;
        }
        public List<Gorus> liste_soneklenen(int Adet,bool durum)
        {
            using IzbursContext db = new IzbursContext();
            var Gorus = db.Gorus.Where(x=>x.Durum==durum).OrderByDescending(x => x.Id).Include(X => X.Kullanici).Include(X => X.Kullanici.Okul).Include(X => X.Kullanici.Bolum).Take(Adet).ToList();
            return Gorus;
        }
        public List<Gorus> Liste(bool durum)
        {
            using IzbursContext db = new IzbursContext();
            var Gorus = db.Gorus.Where(x=>x.Durum==durum).OrderByDescending(x => x.Id).Include(X=>X.Kullanici).ToList();
            return Gorus;
        }
        public List<Gorus> Liste()
        {
            using IzbursContext db = new IzbursContext();
            var Gorus = db.Gorus.OrderByDescending(x => x.Id).Include(X => X.Kullanici).ToList();
            return Gorus;
        }
    }
}
