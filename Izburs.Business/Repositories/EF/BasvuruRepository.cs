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
        public List<Basvuru> Liste(int BursDurum)
        {
            using IzbursContext db = new IzbursContext();
            var data = db.Basvuru.Where(x => x.BursDurumID == BursDurum).Include(x=>x.Okul).Include(x => x.Bolum).Include(x => x.Sehir).ToList();
            return data;

        }
    }
}
