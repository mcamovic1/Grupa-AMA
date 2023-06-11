using Microsoft.EntityFrameworkCore.Migrations;

namespace AMA_cosmetics.Data.Migrations
{
    public partial class PrvobitnoStanje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnik_AspNetUserManagerID",
                table: "Narudzba");

            migrationBuilder.DropIndex(
                name: "IX_Narudzba_AspNetUserManagerID",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "AspNetUserManagerID",
                table: "Narudzba");

            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "Narudzba",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrojTeleona",
                table: "Narudzba",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grad",
                table: "Narudzba",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "Narudzba",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "Narudzba",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnik_NarucilacID",
                table: "Narudzba");

            migrationBuilder.DropIndex(
                name: "IX_Narudzba_NarucilacID",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "BrojTeleona",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "Grad",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "Narudzba");

            migrationBuilder.AddColumn<int>(
                name: "AspNetUserManagerID",
                table: "Narudzba",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_AspNetUserManagerID",
                table: "Narudzba",
                column: "AspNetUserManagerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnik_AspNetUserManagerID",
                table: "Narudzba",
                column: "AspNetUserManagerID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
