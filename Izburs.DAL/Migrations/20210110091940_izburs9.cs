using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Izburs.DAL.Migrations
{
    public partial class izburs9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Basvuru",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TcKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    OgrenciGelir = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OkulTuruId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basvuru", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Basvuru_Bolum_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Basvuru_BursDurum_BursDurumID",
                        column: x => x.BursDurumID,
                        principalTable: "BursDurum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Basvuru_Donem_DonemID",
                        column: x => x.DonemID,
                        principalTable: "Donem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Basvuru_Okul_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okul",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Basvuru_OkulTuru_OkulTuruId",
                        column: x => x.OkulTuruId,
                        principalTable: "OkulTuru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Basvuru_Sehir_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehir",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basvuru_BolumId",
                table: "Basvuru",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Basvuru_BursDurumID",
                table: "Basvuru",
                column: "BursDurumID");

            migrationBuilder.CreateIndex(
                name: "IX_Basvuru_DonemID",
                table: "Basvuru",
                column: "DonemID");

            migrationBuilder.CreateIndex(
                name: "IX_Basvuru_OkulId",
                table: "Basvuru",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_Basvuru_OkulTuruId",
                table: "Basvuru",
                column: "OkulTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_Basvuru_SehirId",
                table: "Basvuru",
                column: "SehirId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basvuru");
        }
    }
}
