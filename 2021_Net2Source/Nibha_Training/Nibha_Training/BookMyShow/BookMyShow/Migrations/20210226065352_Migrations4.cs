using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMyShow.Migrations
{
    public partial class Migrations4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieId_Fk",
                table: "RatingModels");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "RatingModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RatingModels_MovieId",
                table: "RatingModels",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_RatingModels_MovieModels_MovieId",
                table: "RatingModels",
                column: "MovieId",
                principalTable: "MovieModels",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatingModels_MovieModels_MovieId",
                table: "RatingModels");

            migrationBuilder.DropIndex(
                name: "IX_RatingModels_MovieId",
                table: "RatingModels");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "RatingModels");

            migrationBuilder.AddColumn<int>(
                name: "MovieId_Fk",
                table: "RatingModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
