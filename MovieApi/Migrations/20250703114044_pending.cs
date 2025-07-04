using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApi.Migrations
{
    /// <inheritdoc />
    public partial class pending : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_MovieActor_MovieActorMovieId_MovieActorActorId",
                table: "Actor");

            migrationBuilder.DropIndex(
                name: "IX_Actor_MovieActorMovieId_MovieActorActorId",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MovieActor");

            migrationBuilder.DropColumn(
                name: "MovieActorActorId",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "MovieActorMovieId",
                table: "Actor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MovieActor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieActorActorId",
                table: "Actor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieActorMovieId",
                table: "Actor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actor_MovieActorMovieId_MovieActorActorId",
                table: "Actor",
                columns: new[] { "MovieActorMovieId", "MovieActorActorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_MovieActor_MovieActorMovieId_MovieActorActorId",
                table: "Actor",
                columns: new[] { "MovieActorMovieId", "MovieActorActorId" },
                principalTable: "MovieActor",
                principalColumns: new[] { "MovieId", "ActorId" });
        }
    }
}
