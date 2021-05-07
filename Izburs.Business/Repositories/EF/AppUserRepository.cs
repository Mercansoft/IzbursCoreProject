using Izburs.Business.Interfaces;
using Izburs.DAL.Contexts;
using Izburs.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Izburs.Business.Repositories.EF
{
    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {
        //public List<AppUser> Liste(int BursDurumId)
        //{
        //    using IzbursContext db = new IzbursContext();
        //    return db.Users.Where(x=>x.b)
        //}
    }
}
