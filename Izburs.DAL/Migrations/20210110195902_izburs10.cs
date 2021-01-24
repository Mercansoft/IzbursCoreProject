using Microsoft.EntityFrameworkCore.Migrations;

namespace Izburs.DAL.Migrations
{
    public partial class izburs10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Basvuru");

            migrationBuilder.CreateTable(
                name: "OgrenciBasvuru",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasvuruId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciBasvuru", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciBasvuru_Basvuru_BasvuruId",
                        column: x => x.BasvuruId,
                        principalTable: "Basvuru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciBasvuru_BasvuruId",
                table: "OgrenciBasvuru",
                column: "BasvuruId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgrenciBasvuru");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Basvuru",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
