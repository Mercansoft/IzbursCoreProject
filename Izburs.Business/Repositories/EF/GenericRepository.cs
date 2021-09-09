using Izburs.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Izburs.Business.Repositories.EF
{
    public class GenericRepository<Tablo> where Tablo : class, new()
    {
        private DbSet<Tablo> _dbSet;
        public bool Ekle(Tablo tablo)
        {
            try
            {
                using var context = new IzbursContext();
                context.Set<Tablo>().Add(tablo);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Guncelle(Tablo tablo)
        {
            try
            {
                using var context = new IzbursContext();
                context.Set<Tablo>().Update(tablo);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Sil(Tablo tablo)
        {
            try
            {
                using var context = new IzbursContext();
                context.Set<Tablo>().Remove(tablo);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Tablo> GetirHepsi()
        {
            using var context = new IzbursContext();
            return context.Set<Tablo>().ToList();
        }
        public List<Tablo> GetirHepsi(int Adet)
        {
            using var context = new IzbursContext();
            return context.Set<Tablo>().Take(Adet).ToList();
        }
        public Tablo GetirIdile(int id)
        {
            using var context = new IzbursContext();
            return context.Set<Tablo>().Find(id);
        }
        public virtual IEnumerable<Tablo> Select(Expression<Func<Tablo, bool>> Filter = null)
        {
            if (Filter != null)
            {
                return _dbSet.Where(Filter);
            }
            return _dbSet;
        }
        //public Tablo SonEklenen()
        //{
        //    using var context = new IzbursContext();
        //    return context.Set<Tablo>().OrderByDescending()
        //}
    }
}
