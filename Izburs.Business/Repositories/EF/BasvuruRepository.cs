using Izburs.DAL.Entities;
using Izburs.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Izburs.DAL.Contexts;
using System.Linq;
using Izburs.Business.Enum;
using Microsoft.EntityFrameworkCore;

namespace Izburs.Business.Repositories.EF
{
    public class BasvuruRepository : GenericRepository<Basvuru>, IBasvuruRepository
    {
        public List<Basvuru> Liste()
        {
            using IzbursContext db = new IzbursContext();
            var data = db.Basvuru.Include(x => x.OkulTuru).Include(x => x.Donem).Include(x => x.BursDurum).Include(x => x.Okul).Include(x => x.Bolum).Include(x => x.Sehir).ToList();
            return data;

        }
        public List<Basvuru> Liste(int BursDurum)
        {
            using IzbursContext db = new IzbursContext();
            var data = db.Basvuru.Where(x => x.BursDurumID == BursDurum).Include(x => x.OkulTuru).Include(x => x.Donem).Include(x => x.BursDurum).Include(x=>x.Okul).Include(x => x.Bolum).Include(x => x.Sehir).ToList();
            return data;

        }
        public Basvuru GetirID(int id)
        {
            using IzbursContext db = new IzbursContext();
            var data = db.Basvuru.Where(x => x.Id == id).Include(x => x.OkulTuru).Include(x => x.Donem).Include(x => x.BursDurum).Include(x => x.Okul).Include(x => x.Bolum).Include(x => x.Sehir).FirstOrDefault();
            return data;

        }
        public List<Basvuru> ListeDonem(int DonemId)
        {
            using IzbursContext db = new IzbursContext();
            var data = db.Basvuru.Where(x=>x.DonemID==DonemId).Include(x => x.OkulTuru).Include(x => x.Donem).Include(x => x.BursDurum).Include(x => x.Okul).Include(x => x.Bolum).Include(x => x.Sehir).ToList();
            return data;

        }
        public List<Basvuru> Liste(string Tc)
        {
            using IzbursContext db = new IzbursContext();
            var data = db.Basvuru.Where(x => x.TcKimlikNo == Tc).Include(x => x.OkulTuru).Include(x => x.Donem).Include(x => x.BursDurum).Include(x => x.Okul).Include(x => x.Bolum).Include(x => x.Sehir).ToList();
            return data;

        }
    }
}
