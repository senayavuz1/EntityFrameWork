using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstWin.Migrations
{
    public partial class SonsuzKategori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategoriler_Kategoriler_UstKategoriId",
                table: "Kategoriler");

            migrationBuilder.AlterColumn<int>(
                name: "UstKategoriId",
                table: "Kategoriler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategoriler_Kategoriler_UstKategoriId",
                table: "Kategoriler",
                column: "UstKategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategoriler_Kategoriler_UstKategoriId",
                table: "Kategoriler");

            migrationBuilder.AlterColumn<int>(
                name: "UstKategoriId",
                table: "Kategoriler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kategoriler_Kategoriler_UstKategoriId",
                table: "Kategoriler",
                column: "UstKategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
