using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfTour.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Courses_CourseId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Courses_CourseId1",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "CourseId1",
                table: "Players",
                newName: "PgaTourId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Players",
                newName: "GolfRankingId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_CourseId1",
                table: "Players",
                newName: "IX_Players_PgaTourId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_CourseId",
                table: "Players",
                newName: "IX_Players_GolfRankingId");

            migrationBuilder.AddColumn<int>(
                name: "FedexCupId",
                table: "PlayerQualifieds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PgaTourId",
                table: "PlayerQualifieds",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageTour",
                table: "PgaTours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Designer",
                table: "PgaTours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "PgaTours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "PgaTours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CoursePlayer",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    PlayersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePlayer", x => new { x.CoursesId, x.PlayersId });
                    table.ForeignKey(
                        name: "FK_CoursePlayer_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoursePlayer_Players_PlayersId",
                        column: x => x.PlayersId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerQualifieds_FedexCupId",
                table: "PlayerQualifieds",
                column: "FedexCupId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerQualifieds_PgaTourId",
                table: "PlayerQualifieds",
                column: "PgaTourId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePlayer_PlayersId",
                table: "CoursePlayer",
                column: "PlayersId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerQualifieds_FedexCups_FedexCupId",
                table: "PlayerQualifieds",
                column: "FedexCupId",
                principalTable: "FedexCups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerQualifieds_PgaTours_PgaTourId",
                table: "PlayerQualifieds",
                column: "PgaTourId",
                principalTable: "PgaTours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_GolfRankings_GolfRankingId",
                table: "Players",
                column: "GolfRankingId",
                principalTable: "GolfRankings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_PgaTours_PgaTourId",
                table: "Players",
                column: "PgaTourId",
                principalTable: "PgaTours",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerQualifieds_FedexCups_FedexCupId",
                table: "PlayerQualifieds");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerQualifieds_PgaTours_PgaTourId",
                table: "PlayerQualifieds");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_GolfRankings_GolfRankingId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_PgaTours_PgaTourId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "CoursePlayer");

            migrationBuilder.DropIndex(
                name: "IX_PlayerQualifieds_FedexCupId",
                table: "PlayerQualifieds");

            migrationBuilder.DropIndex(
                name: "IX_PlayerQualifieds_PgaTourId",
                table: "PlayerQualifieds");

            migrationBuilder.DropColumn(
                name: "FedexCupId",
                table: "PlayerQualifieds");

            migrationBuilder.DropColumn(
                name: "PgaTourId",
                table: "PlayerQualifieds");

            migrationBuilder.RenameColumn(
                name: "PgaTourId",
                table: "Players",
                newName: "CourseId1");

            migrationBuilder.RenameColumn(
                name: "GolfRankingId",
                table: "Players",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_PgaTourId",
                table: "Players",
                newName: "IX_Players_CourseId1");

            migrationBuilder.RenameIndex(
                name: "IX_Players_GolfRankingId",
                table: "Players",
                newName: "IX_Players_CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "ImageTour",
                table: "PgaTours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Designer",
                table: "PgaTours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "PgaTours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "PgaTours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Courses_CourseId",
                table: "Players",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Courses_CourseId1",
                table: "Players",
                column: "CourseId1",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
