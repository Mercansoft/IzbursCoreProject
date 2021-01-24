using System;
using System.Collections.Generic;
using System.Text;

namespace Izburs.Business.Interfaces
{
    public interface IGenericRepository<Tablo> where Tablo : class, new()
    {
        bool Ekle(Tablo tablo);
        bool Guncelle(Tablo tablo);
        bool Sil(Tablo tablo);
        public List<Tablo> GetirHepsi();
        public Tablo GetirIdile(int id);
    }
}
