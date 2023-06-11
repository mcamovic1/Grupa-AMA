using Microsoft.EntityFrameworkCore.Migrations;

namespace AMA_cosmetics.Data.Migrations
{
    public partial class promenaNarudzbe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnik_NarucilacID",
                table: "Narudzba");

            migrationBuilder.DropIndex(
                name: "IX_Narudzba_NarucilacID",
                table: "Narudzba");

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Narudzba",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KorisnikID",
                table: "Narudzba",
                column: "KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnik_KorisnikID",
                table: "Narudzba",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnik_KorisnikID",
                table: "Narudzba");

            migrationBuilder.DropIndex(
                name: "IX_Narudzba_KorisnikID",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Narudzba");

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
