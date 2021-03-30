using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMyShow.Migrations
{
    public partial class ratingmodelfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RatingModels",
                columns: table => new
                {
                    RatingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieRatings = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    MovieModelMovieID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingModels", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_RatingModels_MovieModels_MovieModelMovieID",
                        column: x => x.MovieModelMovieID,
                        principalTable: "MovieModels",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RatingModels_MovieModelMovieID",
                table: "RatingModels",
                column: "MovieModelMovieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RatingModels");
        }
    }
}
