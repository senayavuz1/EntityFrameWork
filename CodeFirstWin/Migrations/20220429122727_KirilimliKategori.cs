using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstWin.Migrations
{
    public partial class KirilimliKategori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UstKategoriId",
                table: "Kategoriler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_UstKategoriId",
                table: "Kategoriler",
                column: "UstKategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategoriler_Kategoriler_UstKategoriId",
                table: "Kategoriler",
                column: "UstKategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategoriler_Kategoriler_UstKategoriId",
                table: "Kategoriler");

            migrationBuilder.DropIndex(
                name: "IX_Kategoriler_UstKategoriId",
                table: "Kategoriler");

            migrationBuilder.DropColumn(
                name: "UstKategoriId",
                table: "Kategoriler");
        }
    }
}
