using Izburs.Business.Interfaces;
using Izburs.DAL.Contexts;
using Izburs.DAL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Izburs.Business.Repositories.EF
{
    public class HaberRepository : GenericRepository<Haber>,IHaberRepository
    {
        public Haber GetirHaberId(int id)
        {
            using IzbursContext db = new IzbursContext();
            var haber = db.Haber.Where(x => x.Id == id & x.Durum == true).Include(x=>x.Yorumlar).FirstOrDefault();
            //haber.Yorumlar = db.Yorum.Where(x => x.HaberId == id).ToList();
            return haber;
        }
        public List<Haber> CokOkunanHaber(int Adet)
        {
            using IzbursContext db = new IzbursContext();
            var haber = db.Haber.OrderByDescending(x => x.Hit).Take(Adet).ToList();
            //return View(grp.Select(null).OrderByDescending(x=>x.Id).Take(12).ToList());
            return haber;
        }
    }
}
