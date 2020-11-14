using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArizaTakip.DataAccess.Migrations
{
    public partial class baslangic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ariza",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArizaTanim = table.Column<string>(maxLength: 100, nullable: false),
                    ArizaAciklama = table.Column<string>(type: "ntext", nullable: true),
                    ArizaOlusturulmaTarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ariza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cevap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CevapAciklama = table.Column<string>(nullable: true),
                    ArizaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cevap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cihaz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CihazAd = table.Column<string>(nullable: true),
                    CihazTip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cihaz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CihazOzellik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COzellikTanim = table.Column<string>(nullable: true),
                    COzellikDeger = table.Column<string>(nullable: true),
                    CihazId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CihazOzellik", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ariza");

            migrationBuilder.DropTable(
                name: "Cevap");

            migrationBuilder.DropTable(
                name: "Cihaz");

            migrationBuilder.DropTable(
                name: "CihazOzellik");
        }
    }
}
