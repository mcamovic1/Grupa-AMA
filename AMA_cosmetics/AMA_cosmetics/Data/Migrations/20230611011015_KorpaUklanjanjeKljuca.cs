using Microsoft.EntityFrameworkCore.Migrations;

namespace AMA_cosmetics.Data.Migrations
{
    public partial class KorpaUklanjanjeKljuca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_Korisnik_IDKorisnik",
                table: "Korpa");

            migrationBuilder.DropIndex(
                name: "IX_Korpa_IDKorisnik",
                table: "Korpa");

            migrationBuilder.AlterColumn<string>(
                name: "IDKorisnik",
                table: "Korpa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Korpa",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Korpa");

            migrationBuilder.AlterColumn<int>(
                name: "IDKorisnik",
                table: "Korpa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_IDKorisnik",
                table: "Korpa",
                column: "IDKorisnik");

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_Korisnik_IDKorisnik",
                table: "Korpa",
                column: "IDKorisnik",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
