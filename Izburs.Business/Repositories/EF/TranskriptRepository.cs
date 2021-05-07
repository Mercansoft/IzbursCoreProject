using Izburs.Business.Interfaces;
using Izburs.DAL.Contexts;
using Izburs.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Izburs.Business.Repositories.EF
{
    public class TranskriptRepository : GenericRepository<Transkript>, ITranskriptRepository
    {
        public List<Transkript> Liste(string AppUserId)
        {
            using IzbursContext db = new IzbursContext();
            return db.Transkript.Where(x => x.AppUserId == AppUserId).Include(x => x.Donem).OrderByDescending(x=>x.Id).ToList();
        }
        public List<Transkript> Liste(string AppUserId, int DonemId)
        {
            using IzbursContext db = new IzbursContext();
            return db.Transkript.Where(x => x.AppUserId == AppUserId&x.DonemId==DonemId).Include(x => x.Donem).OrderByDescending(x => x.Id).ToList();
        }
    }
}
