using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Izburs.DAL.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ayar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Html = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ayar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bolum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BursDurum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BursDurum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Donem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HaberKat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaberKat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meslek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meslek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Okul",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okul", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OkulTuru",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OkulTuru", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sayfa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sayfa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sehir",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehir", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transkript",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dosya = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    DonemId = table.Column<int>(type: "int", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transkript", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transkript_Donem_DonemId",
                        column: x => x.DonemId,
                        principalTable: "Donem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Haber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaberKatId = table.Column<int>(type: "int", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haber_HaberKat_HaberKatId",
                        column: x => x.HaberKatId,
                        principalTable: "HaberKat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TcKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BolumId = table.Column<int>(type: "int", nullable: false),
                    OkulId = table.Column<int>(type: "int", nullable: false),
                    BursDurumID = table.Column<int>(type: "int", nullable: false),
                    DonemID = table.Column<int>(type: "int", nullable: false),
                    AnneMeslekID = table.Column<int>(type: "int", nullable: false),
                    BabamMeslekID = table.Column<int>(type: "int", nullable: false),
                    SehirId = table.Column<int>(type: "int", nullable: false),
                    Sinif = table.Column<int>(type: "int", nullable: false),
                    Gelir = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Is = table.Column<bool>(type: "bit", nullable: false),
                    BaskaBurs = table.Column<bool>(type: "bit", nullable: false),
                    BursNerden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UyeDernek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OzelUgras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BabaSag = table.Column<bool>(type: "bit", nullable: false),
                    AnneSag = table.Column<bool>(type: "bit", nullable: false),
                    AnneBabaBirlikte = table.Column<bool>(type: "bit", nullable: false),
                    EvKirami = table.Column<bool>(type: "bit", nullable: false),
                    BabaGelir = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AnneGelir = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EvKiraUcreti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AileGayriMenkul = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KardesVarYok = table.Column<bool>(type: "bit", nullable: false),
                    KardesSayisi = table.Column<int>(type: "int", nullable: false),
                    KardesIsOkul = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkrabaDereceGelir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TavsiyeEdenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BilgiKisiveTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DigerBilgiler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HesapNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puan = table.Column<int>(type: "int", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    OgrenciGelir = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OkulTuruId = table.Column<int>(type: "int", nullable: false),
                    MeslekId = table.Column<int>(type: "int", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanici_Bolum_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanici_BursDurum_BursDurumID",
                        column: x => x.BursDurumID,
                        principalTable: "BursDurum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanici_Donem_DonemID",
                        column: x => x.DonemID,
                        principalTable: "Donem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanici_Meslek_MeslekId",
                        column: x => x.MeslekId,
                        principalTable: "Meslek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kullanici_Okul_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okul",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanici_OkulTuru_OkulTuruId",
                        column: x => x.OkulTuruId,
                        principalTable: "OkulTuru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanici_Sehir_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehir",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gorus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gorus_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gorus_KullaniciId",
                table: "Gorus",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Haber_HaberKatId",
                table: "Haber",
                column: "HaberKatId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_BolumId",
                table: "Kullanici",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_BursDurumID",
                table: "Kullanici",
                column: "BursDurumID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_DonemID",
                table: "Kullanici",
                column: "DonemID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_MeslekId",
                table: "Kullanici",
                column: "MeslekId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_OkulId",
                table: "Kullanici",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_OkulTuruId",
                table: "Kullanici",
                column: "OkulTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_SehirId",
                table: "Kullanici",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_Transkript_DonemId",
                table: "Transkript",
                column: "DonemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ayar");

            migrationBuilder.DropTable(
                name: "Gorus");

            migrationBuilder.DropTable(
                name: "Haber");

            migrationBuilder.DropTable(
                name: "Sayfa");

            migrationBuilder.DropTable(
                name: "Transkript");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "HaberKat");

            migrationBuilder.DropTable(
                name: "Bolum");

            migrationBuilder.DropTable(
                name: "BursDurum");

            migrationBuilder.DropTable(
                name: "Donem");

            migrationBuilder.DropTable(
                name: "Meslek");

            migrationBuilder.DropTable(
                name: "Okul");

            migrationBuilder.DropTable(
                name: "OkulTuru");

            migrationBuilder.DropTable(
                name: "Sehir");
        }
    }
}
