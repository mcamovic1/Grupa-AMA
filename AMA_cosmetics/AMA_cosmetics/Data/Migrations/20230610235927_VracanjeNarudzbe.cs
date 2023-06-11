using Microsoft.EntityFrameworkCore.Migrations;

namespace AMA_cosmetics.Data.Migrations
{
    public partial class VracanjeNarudzbe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnik_KorisnikID",
                table: "Narudzba");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Narudzba",
                newName: "AspNetUserManagerID");

            migrationBuilder.RenameIndex(
                name: "IX_Narudzba_KorisnikID",
                table: "Narudzba",
                newName: "IX_Narudzba_AspNetUserManagerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnik_AspNetUserManagerID",
                table: "Narudzba",
                column: "AspNetUserManagerID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnik_AspNetUserManagerID",
                table: "Narudzba");

            migrationBuilder.RenameColumn(
                name: "AspNetUserManagerID",
                table: "Narudzba",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Narudzba_AspNetUserManagerID",
                table: "Narudzba",
                newName: "IX_Narudzba_KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnik_KorisnikID",
                table: "Narudzba",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
