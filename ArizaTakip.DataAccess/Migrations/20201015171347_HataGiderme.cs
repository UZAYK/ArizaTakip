using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArizaTakip.DataAccess.Migrations
{
    public partial class HataGiderme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CihazKayitTarihi",
                table: "Cihaz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CihazKayitTarihi",
                table: "Cihaz");
        }
    }
}
