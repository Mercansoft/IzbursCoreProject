using Izburs.DAL.Entities;
using Izburs.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Izburs.DAL.Contexts;

namespace Izburs.Business.Repositories.EF
{
    public class DonemRepository : GenericRepository<Donem>,IDonemRepository
    {
        public Donem SonDonem()
        {
            using IzbursContext db = new IzbursContext();
            var data = db.Donem.OrderByDescending(x => x.Id).FirstOrDefault();
            return data;
        }
    }
}
