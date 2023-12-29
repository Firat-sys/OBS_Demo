using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_ProgramlamaDilleris_ProgramlamaDilleriID",
                table: "Ogrenci");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramlamaDilleriID",
                table: "Ogrenci",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeslekiIngizceID",
                table: "Ogrenci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SayısalAnalizID",
                table: "Ogrenci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeriTabanıYsSisID",
                table: "Ogrenci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeriY_Id",
                table: "Ogrenci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenci_ProgramlamaDilleris_ProgramlamaDilleriID",
                table: "Ogrenci",
                column: "ProgramlamaDilleriID",
                principalTable: "ProgramlamaDilleris",
                principalColumn: "ProgramlamaDilleriID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_ProgramlamaDilleris_ProgramlamaDilleriID",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "MeslekiIngizceID",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "SayısalAnalizID",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "VeriTabanıYsSisID",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "VeriY_Id",
                table: "Ogrenci");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramlamaDilleriID",
                table: "Ogrenci",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenci_ProgramlamaDilleris_ProgramlamaDilleriID",
                table: "Ogrenci",
                column: "ProgramlamaDilleriID",
                principalTable: "ProgramlamaDilleris",
                principalColumn: "ProgramlamaDilleriID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
