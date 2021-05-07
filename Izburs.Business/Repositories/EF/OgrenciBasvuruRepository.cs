using Izburs.Business.Interfaces;
using Izburs.DAL.Contexts;
using Izburs.DAL.Entities;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;

namespace Izburs.Business.Repositories.EF
{
    public class OgrenciBasvuruRepository : GenericRepository<OgrenciBasvuru>, IOgrenciBasvuruRepository
    {
        public List<OgrenciBasvuru> GetirAppUserId(string AppUserId)
        {
            using IzbursContext db = new IzbursContext();
            var haber = db.OgrenciBasvuru.Where(x =>x.AppUserId == AppUserId).Include(x => x.Basvuru).ToList();
            //haber.Yorumlar = db.Yorum.Where(x => x.HaberId == id).ToList();
            return haber;
        }
        public OgrenciBasvuru GetirBasvuruId(int BasvuruId)
        {
            using IzbursContext db = new IzbursContext();
            var haber = db.OgrenciBasvuru.Where(x => x.BasvuruId == BasvuruId).Include(x => x.Basvuru).FirstOrDefault();
            //haber.Yorumlar = db.Yorum.Where(x => x.HaberId == id).ToList();
            return haber;
        }
    }
}
