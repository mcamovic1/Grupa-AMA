using Microsoft.EntityFrameworkCore.Migrations;

namespace AMA_cosmetics.Data.Migrations
{
    public partial class migracija4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "KorisikID",
                table: "DodeljeniPopusti");

            migrationBuilder.RenameColumn(
                name: "PopustiID",
                table: "DodeljeniPopusti",
                newName: "PremiumKorisikID");

            migrationBuilder.RenameIndex(
                name: "IX_DodeljeniPopusti_PopustiID",
                table: "DodeljeniPopusti",
                newName: "IX_DodeljeniPopusti_PremiumKorisikID");

            migrationBuilder.CreateIndex(
                name: "IX_DodeljeniPopusti_IDPopust",
                table: "DodeljeniPopusti",
                column: "IDPopust");

            migrationBuilder.AddForeignKey(
                name: "FK_DodeljeniPopusti_Popust_IDPopust",
                table: "DodeljeniPopusti",
                column: "IDPopust",
                principalTable: "Popust",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DodeljeniPopusti_PremiumKorisnik_PremiumKorisikID",
                table: "DodeljeniPopusti",
                column: "PremiumKorisikID",
                principalTable: "PremiumKorisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodeljeniPopusti_Popust_IDPopust",
                table: "DodeljeniPopusti");

            migrationBuilder.DropForeignKey(
                name: "FK_DodeljeniPopusti_PremiumKorisnik_PremiumKorisikID",
                table: "DodeljeniPopusti");

            migrationBuilder.DropIndex(
                name: "IX_DodeljeniPopusti_IDPopust",
                table: "DodeljeniPopusti");

            migrationBuilder.RenameColumn(
                name: "PremiumKorisikID",
                table: "DodeljeniPopusti",
                newName: "PopustiID");

            migrationBuilder.RenameIndex(
                name: "IX_DodeljeniPopusti_PremiumKorisikID",
                table: "DodeljeniPopusti",
                newName: "IX_DodeljeniPopusti_PopustiID");

            migrationBuilder.AddColumn<int>(
                name: "KorisikID",
                table: "DodeljeniPopusti",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DodeljeniPopusti_KorisikID",
                table: "DodeljeniPopusti",
                column: "KorisikID");

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
    }
}
