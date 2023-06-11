using Microsoft.EntityFrameworkCore.Migrations;

namespace AMA_cosmetics.Data.Migrations
{
    public partial class NarudzbaUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnik_NarucilacID",
                table: "Narudzba");

            migrationBuilder.DropIndex(
                name: "IX_Narudzba_NarucilacID",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "NarucilacID",
                table: "Narudzba");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Narudzba",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Narudzba");

            migrationBuilder.AddColumn<int>(
                name: "NarucilacID",
                table: "Narudzba",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_NarucilacID",
                table: "Narudzba",
                column: "NarucilacID");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnik_NarucilacID",
                table: "Narudzba",
                column: "NarucilacID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
