using Izburs.Business.Interfaces;
using Izburs.DAL.Contexts;
using Izburs.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Izburs.Business.Repositories.EF
{
    public class YorumRepository : GenericRepository<Yorum>,IYorumRepository
    {
        public List<Yorum> listHaberId(int haberId)
        {
            using IzbursContext db = new IzbursContext();
            return db.Yorum.Where(x => x.HaberId == haberId&x.Durum==false).AsNoTracking().ToList();
        }
    }
}
