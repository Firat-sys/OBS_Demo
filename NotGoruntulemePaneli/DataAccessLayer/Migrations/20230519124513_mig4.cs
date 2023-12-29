using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogrenci",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciSinifi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    meslekiInglizceMeslekiIngizceID = table.Column<int>(type: "int", nullable: true),
                    ProgramlamaDilleriID = table.Column<int>(type: "int", nullable: true),
                    sayisalAnalizSayısalAnalizID = table.Column<int>(type: "int", nullable: true),
                    veriTabaniVeriTabanıYsSisID = table.Column<int>(type: "int", nullable: true),
                    VeriYapilariVeriY_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenci", x => x.OgrenciId);
                    table.ForeignKey(
                        name: "FK_Ogrenci_MeslekiInglizces_meslekiInglizceMeslekiIngizceID",
                        column: x => x.meslekiInglizceMeslekiIngizceID,
                        principalTable: "MeslekiInglizces",
                        principalColumn: "MeslekiIngizceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogrenci_ProgramlamaDilleris_ProgramlamaDilleriID",
                        column: x => x.ProgramlamaDilleriID,
                        principalTable: "ProgramlamaDilleris",
                        principalColumn: "ProgramlamaDilleriID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogrenci_SayisalAnalizs_sayisalAnalizSayısalAnalizID",
                        column: x => x.sayisalAnalizSayısalAnalizID,
                        principalTable: "SayisalAnalizs",
                        principalColumn: "SayısalAnalizID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogrenci_VeriTabaniYsSiss_veriTabaniVeriTabanıYsSisID",
                        column: x => x.veriTabaniVeriTabanıYsSisID,
                        principalTable: "VeriTabaniYsSiss",
                        principalColumn: "VeriTabanıYsSisID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogrenci_VeriYapilaris_VeriYapilariVeriY_Id",
                        column: x => x.VeriYapilariVeriY_Id,
                        principalTable: "VeriYapilaris",
                        principalColumn: "VeriY_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_meslekiInglizceMeslekiIngizceID",
                table: "Ogrenci",
                column: "meslekiInglizceMeslekiIngizceID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_ProgramlamaDilleriID",
                table: "Ogrenci",
                column: "ProgramlamaDilleriID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_sayisalAnalizSayısalAnalizID",
                table: "Ogrenci",
                column: "sayisalAnalizSayısalAnalizID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_veriTabaniVeriTabanıYsSisID",
                table: "Ogrenci",
                column: "veriTabaniVeriTabanıYsSisID");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_VeriYapilariVeriY_Id",
                table: "Ogrenci",
                column: "VeriYapilariVeriY_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrenci");
        }
    }
}
