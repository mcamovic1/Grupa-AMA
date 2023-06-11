using Microsoft.EntityFrameworkCore.Migrations;

namespace AMA_cosmetics.Data.Migrations
{
    public partial class dodavanjeAtributaUKorpa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cijena",
                table: "Korpa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "kolicina",
                table: "Korpa",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "kolicina",
                table: "Korpa");
        }
    }
}
