using Microsoft.EntityFrameworkCore.Migrations;

namespace AMA_cosmetics.Data.Migrations
{
    public partial class migracija5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodeljeniPopusti_PremiumKorisnik_PremiumKorisikID",
                table: "DodeljeniPopusti");

            migrationBuilder.DropIndex(
                name: "IX_DodeljeniPopusti_PremiumKorisikID",
                table: "DodeljeniPopusti");

            migrationBuilder.DropColumn(
                name: "PremiumKorisikID",
                table: "DodeljeniPopusti");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_PisacRecenzijeID",
                table: "Recenzija",
                column: "PisacRecenzijeID");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_ProizvodID",
                table: "Recenzija",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Pomoc_KorisnikID",
                table: "Pomoc",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_NarucilacID",
                table: "Narudzba",
                column: "NarucilacID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_PlacanjeID",
                table: "Narudzba",
                column: "PlacanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_NaruceniProizvodi_IDNarudzba",
                table: "NaruceniProizvodi",
                column: "IDNarudzba");

            migrationBuilder.CreateIndex(
                name: "IX_NaruceniProizvodi_IDProizvod",
                table: "NaruceniProizvodi",
                column: "IDProizvod");

            migrationBuilder.CreateIndex(
                name: "IX_ListaZelja_KorisnikID",
                table: "ListaZelja",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_ListaZelja_ProizvodID",
                table: "ListaZelja",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_IDKorisnik",
                table: "Korpa",
                column: "IDKorisnik");

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_IDProizvod",
                table: "Korpa",
                column: "IDProizvod");

            migrationBuilder.CreateIndex(
                name: "IX_Dostava_NarudzbaID",
                table: "Dostava",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_DodeljeniPopusti_IDKorisnika",
                table: "DodeljeniPopusti",
                column: "IDKorisnika");

            migrationBuilder.AddForeignKey(
                name: "FK_DodeljeniPopusti_PremiumKorisnik_IDKorisnika",
                table: "DodeljeniPopusti",
                column: "IDKorisnika",
                principalTable: "PremiumKorisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dostava_Narudzba_NarudzbaID",
                table: "Dostava",
                column: "NarudzbaID",
                principalTable: "Narudzba",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_Korisnik_IDKorisnik",
                table: "Korpa",
                column: "IDKorisnik",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_Proizvod_IDProizvod",
                table: "Korpa",
                column: "IDProizvod",
                principalTable: "Proizvod",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaZelja_PremiumKorisnik_KorisnikID",
                table: "ListaZelja",
                column: "KorisnikID",
                principalTable: "PremiumKorisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaZelja_Proizvod_ProizvodID",
                table: "ListaZelja",
                column: "ProizvodID",
                principalTable: "Proizvod",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NaruceniProizvodi_Narudzba_IDNarudzba",
                table: "NaruceniProizvodi",
                column: "IDNarudzba",
                principalTable: "Narudzba",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NaruceniProizvodi_Proizvod_IDProizvod",
                table: "NaruceniProizvodi",
                column: "IDProizvod",
                principalTable: "Proizvod",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnik_NarucilacID",
                table: "Narudzba",
                column: "NarucilacID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Placanje_PlacanjeID",
                table: "Narudzba",
                column: "PlacanjeID",
                principalTable: "Placanje",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pomoc_Korisnik_KorisnikID",
                table: "Pomoc",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzija_PremiumKorisnik_PisacRecenzijeID",
                table: "Recenzija",
                column: "PisacRecenzijeID",
                principalTable: "PremiumKorisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzija_Proizvod_ProizvodID",
                table: "Recenzija",
                column: "ProizvodID",
                principalTable: "Proizvod",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodeljeniPopusti_PremiumKorisnik_IDKorisnika",
                table: "DodeljeniPopusti");

            migrationBuilder.DropForeignKey(
                name: "FK_Dostava_Narudzba_NarudzbaID",
                table: "Dostava");

            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_Korisnik_IDKorisnik",
                table: "Korpa");

            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_Proizvod_IDProizvod",
                table: "Korpa");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaZelja_PremiumKorisnik_KorisnikID",
                table: "ListaZelja");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaZelja_Proizvod_ProizvodID",
                table: "ListaZelja");

            migrationBuilder.DropForeignKey(
                name: "FK_NaruceniProizvodi_Narudzba_IDNarudzba",
                table: "NaruceniProizvodi");

            migrationBuilder.DropForeignKey(
                name: "FK_NaruceniProizvodi_Proizvod_IDProizvod",
                table: "NaruceniProizvodi");

            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnik_NarucilacID",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Placanje_PlacanjeID",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_Pomoc_Korisnik_KorisnikID",
                table: "Pomoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_PremiumKorisnik_PisacRecenzijeID",
                table: "Recenzija");

            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_Proizvod_ProizvodID",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_PisacRecenzijeID",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_ProizvodID",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Pomoc_KorisnikID",
                table: "Pomoc");

            migrationBuilder.DropIndex(
                name: "IX_Narudzba_NarucilacID",
                table: "Narudzba");

            migrationBuilder.DropIndex(
                name: "IX_Narudzba_PlacanjeID",
                table: "Narudzba");

            migrationBuilder.DropIndex(
                name: "IX_NaruceniProizvodi_IDNarudzba",
                table: "NaruceniProizvodi");

            migrationBuilder.DropIndex(
                name: "IX_NaruceniProizvodi_IDProizvod",
                table: "NaruceniProizvodi");

            migrationBuilder.DropIndex(
                name: "IX_ListaZelja_KorisnikID",
                table: "ListaZelja");

            migrationBuilder.DropIndex(
                name: "IX_ListaZelja_ProizvodID",
                table: "ListaZelja");

            migrationBuilder.DropIndex(
                name: "IX_Korpa_IDKorisnik",
                table: "Korpa");

            migrationBuilder.DropIndex(
                name: "IX_Korpa_IDProizvod",
                table: "Korpa");

            migrationBuilder.DropIndex(
                name: "IX_Dostava_NarudzbaID",
                table: "Dostava");

            migrationBuilder.DropIndex(
                name: "IX_DodeljeniPopusti_IDKorisnika",
                table: "DodeljeniPopusti");

            migrationBuilder.AddColumn<int>(
                name: "PremiumKorisikID",
                table: "DodeljeniPopusti",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DodeljeniPopusti_PremiumKorisikID",
                table: "DodeljeniPopusti",
                column: "PremiumKorisikID");

            migrationBuilder.AddForeignKey(
                name: "FK_DodeljeniPopusti_PremiumKorisnik_PremiumKorisikID",
                table: "DodeljeniPopusti",
                column: "PremiumKorisikID",
                principalTable: "PremiumKorisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
