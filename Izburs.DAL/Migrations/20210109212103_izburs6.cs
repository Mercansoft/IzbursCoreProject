using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Izburs.DAL.Migrations
{
    public partial class izburs6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Yorum",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Sehir",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Sayfa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "OkulTuru",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Okul",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Meslek",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "HaberKat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Haber",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "GaleriKat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Galeri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Donem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "BursDurum",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Bolum",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Ayar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SSS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SSS");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Yorum");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Sehir");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Sayfa");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "OkulTuru");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Okul");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Meslek");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "HaberKat");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Haber");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "GaleriKat");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Galeri");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Donem");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "BursDurum");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Bolum");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Ayar");
        }
    }
}
