using Microsoft.EntityFrameworkCore.Migrations;

namespace Izburs.DAL.Migrations
{
    public partial class izburs1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Transkript",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Sehir",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Sayfa",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "OkulTuru",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Okul",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Meslek",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "HaberKat",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Haber",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "GaleriKat",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Galeri",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Donem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "BursDurum",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Bolum",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Ayar",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Transkript");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Sehir");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Sayfa");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "OkulTuru");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Okul");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Meslek");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "HaberKat");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Haber");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "GaleriKat");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Galeri");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Donem");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "BursDurum");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Bolum");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Ayar");
        }
    }
}
