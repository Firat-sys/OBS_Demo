using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeslekiInglizces",
                columns: table => new
                {
                    MeslekiIngizceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vize1 = table.Column<int>(type: "int", nullable: false),
                    Vize2 = table.Column<int>(type: "int", nullable: false),
                    Final = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeslekiInglizces", x => x.MeslekiIngizceID);
                });

            migrationBuilder.CreateTable(
                name: "OgretimUyesis",
                columns: table => new
                {
                    OgretimUyesiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyisim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DersID = table.Column<int>(type: "int", nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimUyesis", x => x.OgretimUyesiID);
                });

            migrationBuilder.CreateTable(
                name: "ProgramlamaDilleris",
                columns: table => new
                {
                    ProgramlamaDilleriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vize1 = table.Column<int>(type: "int", nullable: false),
                    Vize2 = table.Column<int>(type: "int", nullable: false),
                    Final = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramlamaDilleris", x => x.ProgramlamaDilleriID);
                });

            migrationBuilder.CreateTable(
                name: "SayisalAnalizs",
                columns: table => new
                {
                    SayısalAnalizID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vize1 = table.Column<int>(type: "int", nullable: false),
                    Vize2 = table.Column<int>(type: "int", nullable: false),
                    Final = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SayisalAnalizs", x => x.SayısalAnalizID);
                });

            migrationBuilder.CreateTable(
                name: "VeriTabaniYsSiss",
                columns: table => new
                {
                    VeriTabanıYsSisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vize1 = table.Column<int>(type: "int", nullable: false),
                    Vize2 = table.Column<int>(type: "int", nullable: false),
                    Proje = table.Column<int>(type: "int", nullable: false),
                    Final = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeriTabaniYsSiss", x => x.VeriTabanıYsSisID);
                });

            migrationBuilder.CreateTable(
                name: "VeriYapilaris",
                columns: table => new
                {
                    VeriY_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vize1 = table.Column<int>(type: "int", nullable: false),
                    Proje1 = table.Column<int>(type: "int", nullable: false),
                    Proje2 = table.Column<int>(type: "int", nullable: false),
                    Final = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeriYapilaris", x => x.VeriY_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeslekiInglizces");

            migrationBuilder.DropTable(
                name: "OgretimUyesis");

            migrationBuilder.DropTable(
                name: "ProgramlamaDilleris");

            migrationBuilder.DropTable(
                name: "SayisalAnalizs");

            migrationBuilder.DropTable(
                name: "VeriTabaniYsSiss");

            migrationBuilder.DropTable(
                name: "VeriYapilaris");
        }
    }
}
