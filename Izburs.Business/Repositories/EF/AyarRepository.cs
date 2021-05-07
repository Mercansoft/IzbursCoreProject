using Izburs.Business.Interfaces;
using Izburs.DAL.Contexts;
using Izburs.DAL.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace Izburs.Business.Repositories.EF
{
    public class AyarRepository : GenericRepository<Ayar>, IAyarRepository
    {
        public Ayar Getir()
        {
            using var context = new IzbursContext();
            return context.Ayar.ToList().FirstOrDefault();
        }
    }
}
