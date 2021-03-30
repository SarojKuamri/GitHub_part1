using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentWebApi.Migrations
{
    public partial class InitialApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "models",
                columns: table => new
                {
                    EquipmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentName = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<string>(nullable: true),
                    PurchageDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_models", x => x.EquipmentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "models");
        }
    }
}
