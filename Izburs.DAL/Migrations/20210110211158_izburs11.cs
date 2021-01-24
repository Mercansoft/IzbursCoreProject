using Microsoft.EntityFrameworkCore.Migrations;

namespace Izburs.DAL.Migrations
{
    public partial class izburs11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ad",
                table: "Basvuru",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Basvuru",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Soyad",
                table: "Basvuru",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Basvuru",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ad",
                table: "Basvuru");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Basvuru");

            migrationBuilder.DropColumn(
                name: "Soyad",
                table: "Basvuru");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Basvuru");
        }
    }
}
