using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMyShow.Migrations
{
    public partial class RegisterModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatingModels_MovieModels_MovieModelMovieID",
                table: "RatingModels");

            migrationBuilder.DropIndex(
                name: "IX_RatingModels_MovieModelMovieID",
                table: "RatingModels");

            migrationBuilder.DropColumn(
                name: "MovieModelMovieID",
                table: "RatingModels");

            migrationBuilder.CreateTable(
                name: "RegisterModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    EmailId = table.Column<string>(nullable: false),
                    pwd = table.Column<string>(nullable: false),
                    retypwd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterModels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RatingModels_MovieId",
                table: "RatingModels",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_RatingModels_MovieModels_MovieId",
                table: "RatingModels",
                column: "MovieId",
                principalTable: "MovieModels",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatingModels_MovieModels_MovieId",
                table: "RatingModels");

            migrationBuilder.DropTable(
                name: "RegisterModels");

            migrationBuilder.DropIndex(
                name: "IX_RatingModels_MovieId",
                table: "RatingModels");

            migrationBuilder.AddColumn<int>(
                name: "MovieModelMovieID",
                table: "RatingModels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RatingModels_MovieModelMovieID",
                table: "RatingModels",
                column: "MovieModelMovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_RatingModels_MovieModels_MovieModelMovieID",
                table: "RatingModels",
                column: "MovieModelMovieID",
                principalTable: "MovieModels",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
