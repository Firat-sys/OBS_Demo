using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgretimUyesiID",
                table: "VeriYapilaris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OgretimUyesiID",
                table: "VeriTabaniYsSiss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OgretimUyesiID",
                table: "SayisalAnalizs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OgretimUyesiID",
                table: "ProgramlamaDilleris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OgretimUyesiID",
                table: "MeslekiInglizces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VeriYapilaris_OgretimUyesiID",
                table: "VeriYapilaris",
                column: "OgretimUyesiID");

            migrationBuilder.CreateIndex(
                name: "IX_VeriTabaniYsSiss_OgretimUyesiID",
                table: "VeriTabaniYsSiss",
                column: "OgretimUyesiID");

            migrationBuilder.CreateIndex(
                name: "IX_SayisalAnalizs_OgretimUyesiID",
                table: "SayisalAnalizs",
                column: "OgretimUyesiID");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramlamaDilleris_OgretimUyesiID",
                table: "ProgramlamaDilleris",
                column: "OgretimUyesiID");

            migrationBuilder.CreateIndex(
                name: "IX_MeslekiInglizces_OgretimUyesiID",
                table: "MeslekiInglizces",
                column: "OgretimUyesiID");

            migrationBuilder.AddForeignKey(
                name: "FK_MeslekiInglizces_OgretimUyesis_OgretimUyesiID",
                table: "MeslekiInglizces",
                column: "OgretimUyesiID",
                principalTable: "OgretimUyesis",
                principalColumn: "OgretimUyesiID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramlamaDilleris_OgretimUyesis_OgretimUyesiID",
                table: "ProgramlamaDilleris",
                column: "OgretimUyesiID",
                principalTable: "OgretimUyesis",
                principalColumn: "OgretimUyesiID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SayisalAnalizs_OgretimUyesis_OgretimUyesiID",
                table: "SayisalAnalizs",
                column: "OgretimUyesiID",
                principalTable: "OgretimUyesis",
                principalColumn: "OgretimUyesiID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VeriTabaniYsSiss_OgretimUyesis_OgretimUyesiID",
                table: "VeriTabaniYsSiss",
                column: "OgretimUyesiID",
                principalTable: "OgretimUyesis",
                principalColumn: "OgretimUyesiID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VeriYapilaris_OgretimUyesis_OgretimUyesiID",
                table: "VeriYapilaris",
                column: "OgretimUyesiID",
                principalTable: "OgretimUyesis",
                principalColumn: "OgretimUyesiID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeslekiInglizces_OgretimUyesis_OgretimUyesiID",
                table: "MeslekiInglizces");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramlamaDilleris_OgretimUyesis_OgretimUyesiID",
                table: "ProgramlamaDilleris");

            migrationBuilder.DropForeignKey(
                name: "FK_SayisalAnalizs_OgretimUyesis_OgretimUyesiID",
                table: "SayisalAnalizs");

            migrationBuilder.DropForeignKey(
                name: "FK_VeriTabaniYsSiss_OgretimUyesis_OgretimUyesiID",
                table: "VeriTabaniYsSiss");

            migrationBuilder.DropForeignKey(
                name: "FK_VeriYapilaris_OgretimUyesis_OgretimUyesiID",
                table: "VeriYapilaris");

            migrationBuilder.DropIndex(
                name: "IX_VeriYapilaris_OgretimUyesiID",
                table: "VeriYapilaris");

            migrationBuilder.DropIndex(
                name: "IX_VeriTabaniYsSiss_OgretimUyesiID",
                table: "VeriTabaniYsSiss");

            migrationBuilder.DropIndex(
                name: "IX_SayisalAnalizs_OgretimUyesiID",
                table: "SayisalAnalizs");

            migrationBuilder.DropIndex(
                name: "IX_ProgramlamaDilleris_OgretimUyesiID",
                table: "ProgramlamaDilleris");

            migrationBuilder.DropIndex(
                name: "IX_MeslekiInglizces_OgretimUyesiID",
                table: "MeslekiInglizces");

            migrationBuilder.DropColumn(
                name: "OgretimUyesiID",
                table: "VeriYapilaris");

            migrationBuilder.DropColumn(
                name: "OgretimUyesiID",
                table: "VeriTabaniYsSiss");

            migrationBuilder.DropColumn(
                name: "OgretimUyesiID",
                table: "SayisalAnalizs");

            migrationBuilder.DropColumn(
                name: "OgretimUyesiID",
                table: "ProgramlamaDilleris");

            migrationBuilder.DropColumn(
                name: "OgretimUyesiID",
                table: "MeslekiInglizces");
        }
    }
}
