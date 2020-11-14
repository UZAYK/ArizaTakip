using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArizaTakip.DataAccess.Migrations
{
    public partial class IletisimTablosuEkleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAd = table.Column<string>(maxLength: 100, nullable: false),
                    KullaniciMail = table.Column<string>(type: "ntext", nullable: true),
                    Ileti = table.Column<string>(nullable: true),
                    Fotograf = table.Column<string>(nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iletisims");
        }
    }
}
