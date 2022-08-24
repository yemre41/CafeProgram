using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeProgram.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "icecekler",
                columns: table => new
                {
                    icecekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    icecekName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    icecekValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_icecekler", x => x.icecekId);
                });

            migrationBuilder.CreateTable(
                name: "tatlilar",
                columns: table => new
                {
                    tatlıId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tatlıName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tatlıValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tatlilar", x => x.tatlıId);
                });

            migrationBuilder.CreateTable(
                name: "yiyecekler",
                columns: table => new
                {
                    yiyecekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yiyecekName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yiyecekValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yiyecekler", x => x.yiyecekId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "icecekler");

            migrationBuilder.DropTable(
                name: "tatlilar");

            migrationBuilder.DropTable(
                name: "yiyecekler");
        }
    }
}
