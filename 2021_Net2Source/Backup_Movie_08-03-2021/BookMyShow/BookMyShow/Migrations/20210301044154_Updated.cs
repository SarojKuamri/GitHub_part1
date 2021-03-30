using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMyShow.Migrations
{
    public partial class Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TheatreModels",
                columns: table => new
                {
                    TheatreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThreatreName = table.Column<string>(nullable: false),
                    ThreatreLoccation = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheatreModels", x => x.TheatreId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TheatreModels");
        }
    }
}
