using Microsoft.EntityFrameworkCore.Migrations;

namespace Izburs.DAL.Migrations
{
    public partial class izburs5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorus_Kullanici_KullaniciId",
                table: "Gorus");

            migrationBuilder.DropColumn(
                name: "OgrenciId",
                table: "Gorus");

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciId",
                table: "Gorus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gorus_Kullanici_KullaniciId",
                table: "Gorus",
                column: "KullaniciId",
                principalTable: "Kullanici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorus_Kullanici_KullaniciId",
                table: "Gorus");

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciId",
                table: "Gorus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OgrenciId",
                table: "Gorus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Gorus_Kullanici_KullaniciId",
                table: "Gorus",
                column: "KullaniciId",
                principalTable: "Kullanici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
