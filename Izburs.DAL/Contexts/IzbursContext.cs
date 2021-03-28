using Izburs.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Izburs.DAL.Contexts
{
    public class IzbursContext:IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;" +
                "database=IzbursCore2; user id=sa; password=heyyoo;");

            //IdentityCore dan sonra aşağıdaki kodu ekliyoruz
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Kullanici>().HasMany(i => i.Kullanicilar).WithOne(i => i.Kullanici).HasForeignKey(i => i.KullaniciId);
            modelBuilder.Entity<Bolum>().HasMany(i => i.Kullanicilar).WithOne(i => i.Bolum).HasForeignKey(i => i.BolumId);
            modelBuilder.Entity<BursDurum>().HasMany(i => i.Kullanicilar).WithOne(i => i.BursDurum).HasForeignKey(i => i.BursDurumID);
            modelBuilder.Entity<Donem>().HasMany(i => i.Kullanicilar).WithOne(i => i.Donem).HasForeignKey(i => i.DonemID);
            //modelBuilder.Entity<Meslek>().HasMany(i => i.Basvurular).WithOne(i => i.MeslekAnne).HasForeignKey(i => i.AnneMeslekID);
            //modelBuilder.Entity<Meslek>().HasMany(i => i.Basvurular).WithOne(i => i.MeslekBaba).HasForeignKey(i => i.BabamMeslekID);
            modelBuilder.Entity<Okul>().HasMany(i => i.Kullanicilar).WithOne(i => i.Okul).HasForeignKey(i => i.OkulId);
            modelBuilder.Entity<Sehir>().HasMany(i => i.Kullanicilar).WithOne(i => i.Sehir).HasForeignKey(i => i.SehirId);
            modelBuilder.Entity<OkulTuru>().HasMany(i => i.Kullanicilar).WithOne(i => i.OkulTuru).HasForeignKey(i => i.OkulTuruId);
            modelBuilder.Entity<HaberKat>().HasMany(i => i.Haberler).WithOne(i => i.HaberKat).HasForeignKey(i => i.HaberKatId);
            ///TRANSKRİPT.CS
            modelBuilder.Entity<Donem>().HasMany(i => i.Transkriptler).WithOne(i => i.Donem).HasForeignKey(i => i.DonemId);
            //modelBuilder.Entity<Kullanici>().HasMany(i => i.Transkriptler).WithOne(i => i.Kullanici).HasForeignKey(i => i.OgrenciId);

            //tekrar eden aynı ürünü aynı kategoriye tekrar eklemesini önüne geçme
            //modelBuilder.Entity<UrunKategori>().HasIndex(x => new
            //{
            //    x.KategoriId,
            //    x.UrunId
            //}).IsUnique();

            //IdentityCore dan sonra aşağıdaki kodu ekliyoruz
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Basvuru> Basvuru { get; set; }
        public DbSet<Bolum> Bolum { get; set; }
        public DbSet<BursDurum> BursDurum { get; set; }
        public DbSet<Donem> Donem { get; set; }
        //public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Meslek> Meslek { get; set; }
        public DbSet<Okul> Okul { get; set; }
        public DbSet<OgrenciBasvuru> OgrenciBasvuru { get; set; }
        public DbSet<Sehir> Sehir { get; set; }
        public DbSet<OkulTuru> OkulTuru { get; set; }
        public DbSet<Gorus> Gorus { get; set; }
        public DbSet<Sayfa> Sayfa { get; set; }
        public DbSet<Haber> Haber { get; set; }
        public DbSet<HaberKat> HaberKat { get; set; }
        public DbSet<Transkript> Transkript { get; set; }
        public DbSet<Ayar> Ayar { get; set; }
        public DbSet<GaleriKat> GaleriKat { get; set; }
        public DbSet<Galeri> Galeri { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        public DbSet<SSS> SSS { get; set; }
    }
}
