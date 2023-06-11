using Microsoft.EntityFrameworkCore.Migrations;

namespace AMA_cosmetics.Data.Migrations
{
    public partial class migracija2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KorisikID",
                table: "DodeljeniPopusti",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PopustiID",
                table: "DodeljeniPopusti",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DodeljeniPopusti_KorisikID",
                table: "DodeljeniPopusti",
                column: "KorisikID");

            migrationBuilder.CreateIndex(
                name: "IX_DodeljeniPopusti_PopustiID",
                table: "DodeljeniPopusti",
                column: "PopustiID");

            migrationBuilder.AddForeignKey(
                name: "FK_DodeljeniPopusti_Popust_PopustiID",
                table: "DodeljeniPopusti",
                column: "PopustiID",
                principalTable: "Popust",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DodeljeniPopusti_PremiumKorisnik_KorisikID",
                table: "DodeljeniPopusti",
                column: "KorisikID",
                principalTable: "PremiumKorisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodeljeniPopusti_Popust_PopustiID",
                table: "DodeljeniPopusti");

            migrationBuilder.DropForeignKey(
                name: "FK_DodeljeniPopusti_PremiumKorisnik_KorisikID",
                table: "DodeljeniPopusti");

            migrationBuilder.DropIndex(
                name: "IX_DodeljeniPopusti_KorisikID",
                table: "DodeljeniPopusti");

            migrationBuilder.DropIndex(
                name: "IX_DodeljeniPopusti_PopustiID",
                table: "DodeljeniPopusti");

            migrationBuilder.DropColumn(
                name: "KorisikID",
                table: "DodeljeniPopusti");

            migrationBuilder.DropColumn(
                name: "PopustiID",
                table: "DodeljeniPopusti");
        }
    }
}
