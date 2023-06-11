using Microsoft.EntityFrameworkCore.Migrations;

namespace AMA_cosmetics.Data.Migrations
{
    public partial class brisanjeKlaseNeregistrovani : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NeregistroavniKorisnik");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NeregistroavniKorisnik",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeregistroavniKorisnik", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NeregistroavniKorisnik_Korisnik_ID",
                        column: x => x.ID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });
        }
    }
}
