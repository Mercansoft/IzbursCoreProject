﻿// <auto-generated />
using System;
using Izburs.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Izburs.DAL.Migrations
{
    [DbContext(typeof(IzbursContext))]
    [Migration("20210109202319_izburs5")]
    partial class izburs5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Izburs.DAL.Entities.Ayar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Html")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ayar");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Bolum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Bolum");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.BursDurum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BursDurum");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Donem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Donem");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Galeri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("GaleriKatId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GaleriKatId");

                    b.ToTable("Galeri");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.GaleriKat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GaleriKat");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Gorus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Gorus");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Haber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("HaberKatId")
                        .HasColumnType("int");

                    b.Property<int>("Hit")
                        .HasColumnType("int");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HaberKatId");

                    b.ToTable("Haber");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.HaberKat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HaberKat");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AileGayriMenkul")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AkrabaDereceGelir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AnneBabaBirlikte")
                        .HasColumnType("bit");

                    b.Property<decimal>("AnneGelir")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("AnneMeslekID")
                        .HasColumnType("int");

                    b.Property<bool>("AnneSag")
                        .HasColumnType("bit");

                    b.Property<decimal>("BabaGelir")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("BabaSag")
                        .HasColumnType("bit");

                    b.Property<int>("BabamMeslekID")
                        .HasColumnType("int");

                    b.Property<string>("BankaAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BaskaBurs")
                        .HasColumnType("bit");

                    b.Property<string>("BilgiKisiveTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BolumId")
                        .HasColumnType("int");

                    b.Property<int>("BursDurumID")
                        .HasColumnType("int");

                    b.Property<string>("BursNerden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DigerBilgiler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("DonemID")
                        .HasColumnType("int");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("EvKiraUcreti")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("EvKirami")
                        .HasColumnType("bit");

                    b.Property<decimal>("Gelir")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("HesapNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Iban")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Is")
                        .HasColumnType("bit");

                    b.Property<string>("KardesIsOkul")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KardesSayisi")
                        .HasColumnType("int");

                    b.Property<bool>("KardesVarYok")
                        .HasColumnType("bit");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MeslekId")
                        .HasColumnType("int");

                    b.Property<decimal>("OgrenciGelir")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OkulId")
                        .HasColumnType("int");

                    b.Property<int>("OkulTuruId")
                        .HasColumnType("int");

                    b.Property<string>("OzelUgras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Puan")
                        .HasColumnType("int");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sinif")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TavsiyeEdenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcKimlikNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyeDernek")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BolumId");

                    b.HasIndex("BursDurumID");

                    b.HasIndex("DonemID");

                    b.HasIndex("MeslekId");

                    b.HasIndex("OkulId");

                    b.HasIndex("OkulTuruId");

                    b.HasIndex("SehirId");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Meslek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Meslek");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Okul", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Okul");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.OkulTuru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OkulTuru");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Sayfa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sayfa");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ad")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sehir");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Transkript", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonemId")
                        .HasColumnType("int");

                    b.Property<string>("Dosya")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DonemId");

                    b.ToTable("Transkript");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Yorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("HaberId")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HaberId");

                    b.ToTable("Yorum");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Galeri", b =>
                {
                    b.HasOne("Izburs.DAL.Entities.GaleriKat", "GaleriKat")
                        .WithMany()
                        .HasForeignKey("GaleriKatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GaleriKat");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Gorus", b =>
                {
                    b.HasOne("Izburs.DAL.Entities.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Haber", b =>
                {
                    b.HasOne("Izburs.DAL.Entities.HaberKat", "HaberKat")
                        .WithMany("Haberler")
                        .HasForeignKey("HaberKatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HaberKat");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Kullanici", b =>
                {
                    b.HasOne("Izburs.DAL.Entities.Bolum", "Bolum")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("BolumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Izburs.DAL.Entities.BursDurum", "BursDurum")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("BursDurumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Izburs.DAL.Entities.Donem", "Donem")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("DonemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Izburs.DAL.Entities.Meslek", null)
                        .WithMany("Kullanicilar")
                        .HasForeignKey("MeslekId");

                    b.HasOne("Izburs.DAL.Entities.Okul", "Okul")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("OkulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Izburs.DAL.Entities.OkulTuru", "OkulTuru")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("OkulTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Izburs.DAL.Entities.Sehir", "Sehir")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolum");

                    b.Navigation("BursDurum");

                    b.Navigation("Donem");

                    b.Navigation("Okul");

                    b.Navigation("OkulTuru");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Transkript", b =>
                {
                    b.HasOne("Izburs.DAL.Entities.Donem", "Donem")
                        .WithMany("Transkriptler")
                        .HasForeignKey("DonemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donem");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Yorum", b =>
                {
                    b.HasOne("Izburs.DAL.Entities.Haber", "Haber")
                        .WithMany("Yorumlar")
                        .HasForeignKey("HaberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Haber");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Bolum", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.BursDurum", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Donem", b =>
                {
                    b.Navigation("Kullanicilar");

                    b.Navigation("Transkriptler");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Haber", b =>
                {
                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.HaberKat", b =>
                {
                    b.Navigation("Haberler");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Meslek", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Okul", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.OkulTuru", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Izburs.DAL.Entities.Sehir", b =>
                {
                    b.Navigation("Kullanicilar");
                });
#pragma warning restore 612, 618
        }
    }
}
