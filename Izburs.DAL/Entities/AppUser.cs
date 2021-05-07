using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Izburs.DAL.Entities
{
    public class AppUser:IdentityUser
    {
        public string AdSoyad { get; set; }
        public string Resim { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string BankaAdi { get; set; }
        public string Iban { get; set; }
        public string TcNo { get; set; }
        public string Bolum { get; set; }
        public string Okul { get; set; }
        public int Sinif { get; set; }
        public string OkulTuru { get; set; }
    }
}
