using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfTour.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewDbTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FedexCups_GolfRankings_GolfRankingId",
                table: "FedexCups");

            migrationBuilder.DropForeignKey(
                name: "FK_FedexCups_GolfTourUser_GolfTourUserId",
                table: "FedexCups");

            migrationBuilder.DropForeignKey(
                name: "FK_GolfRankings_GolfTourUser_GolfTourUserId",
                table: "GolfRankings");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_GolfRankings_GolfRankingId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Courses_CourseId",
                table: "Tours");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_GolfRankings_GolfRankingId",
                table: "Tours");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_TypeTours_TypeTourId",
                table: "Tours");

            migrationBuilder.DropTable(
                name: "CourseFedexCup");

            migrationBuilder.DropTable(
                name: "CoursePlayer");

            migrationBuilder.DropTable(
                name: "FedexCupPlayer");

            migrationBuilder.DropTable(
                name: "FedexCupTour");

            migrationBuilder.DropTable(
                name: "Newses");

            migrationBuilder.DropTable(
                name: "PlayerTour");

            migrationBuilder.DropIndex(
                name: "IX_Tours_CourseId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_GolfRankingId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_GolfRankings_GolfTourUserId",
                table: "GolfRankings");

            migrationBuilder.DropIndex(
                name: "IX_FedexCups_GolfRankingId",
                table: "FedexCups");

            migrationBuilder.DropIndex(
                name: "IX_FedexCups_GolfTourUserId",
                table: "FedexCups");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TypeTours");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "Courses",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "GolfRankingId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "Player",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "TypeTour",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "GolfTourUserId",
                table: "GolfRankings");

            migrationBuilder.DropColumn(
                name: "MoneyPrize",
                table: "GolfRankings");

            migrationBuilder.DropColumn(
                name: "City",
                table: "FedexCups");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "FedexCups");

            migrationBuilder.DropColumn(
                name: "GolfRankingId",
                table: "FedexCups");

            migrationBuilder.DropColumn(
                name: "GolfTourUserId",
                table: "FedexCups");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "FedexCups");

            migrationBuilder.DropColumn(
                name: "Player",
                table: "FedexCups");

            migrationBuilder.DropColumn(
                name: "Holes",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Par",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "YearBuilt",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "MoneyPrize",
                table: "Tours",
                newName: "PrizeMoney");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Players",
                newName: "ImagePlayer");

            migrationBuilder.RenameColumn(
                name: "GolfRankingId",
                table: "Players",
                newName: "TypeTourId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_GolfRankingId",
                table: "Players",
                newName: "IX_Players_TypeTourId");

            migrationBuilder.RenameColumn(
                name: "ScoringRanking",
                table: "GolfRankings",
                newName: "PrizeMoney");

            migrationBuilder.RenameColumn(
                name: "MoneyPrize",
                table: "FedexCups",
                newName: "TournamentsPlayed");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Courses",
                newName: "ImageCourse");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "TypeTours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "TypeTours",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TypeTours",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "TypeTours",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeTourId",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "Tours",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId1",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TourId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "GolfRankings",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "FedexCups",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AddColumn<int>(
                name: "PlayerQualifiedId",
                table: "FedexCups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrizeMoney",
                table: "FedexCups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FedexCupId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GolfRankingId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PgaTourId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TourId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PlayerQualifieds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerQualifieds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerQualifieds_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerQualifieds_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PgaTours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerQualifiedId = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageTour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PgaTours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PgaTours_PlayerQualifieds_PlayerQualifiedId",
                        column: x => x.PlayerQualifiedId,
                        principalTable: "PlayerQualifieds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TypeTours_IsDeleted",
                table: "TypeTours",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Players_CourseId",
                table: "Players",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_CourseId1",
                table: "Players",
                column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TourId",
                table: "Players",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_FedexCups_PlayerQualifiedId",
                table: "FedexCups",
                column: "PlayerQualifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_FedexCupId",
                table: "Courses",
                column: "FedexCupId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_GolfRankingId",
                table: "Courses",
                column: "GolfRankingId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_PgaTourId",
                table: "Courses",
                column: "PgaTourId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TourId",
                table: "Courses",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_PgaTours_IsDeleted",
                table: "PgaTours",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PgaTours_PlayerQualifiedId",
                table: "PgaTours",
                column: "PlayerQualifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerQualifieds_IsDeleted",
                table: "PlayerQualifieds",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerQualifieds_PlayerId",
                table: "PlayerQualifieds",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerQualifieds_TourId",
                table: "PlayerQualifieds",
                column: "TourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_FedexCups_FedexCupId",
                table: "Courses",
                column: "FedexCupId",
                principalTable: "FedexCups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_GolfRankings_GolfRankingId",
                table: "Courses",
                column: "GolfRankingId",
                principalTable: "GolfRankings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_PgaTours_PgaTourId",
                table: "Courses",
                column: "PgaTourId",
                principalTable: "PgaTours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Tours_TourId",
                table: "Courses",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FedexCups_PlayerQualifieds_PlayerQualifiedId",
                table: "FedexCups",
                column: "PlayerQualifiedId",
                principalTable: "PlayerQualifieds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Tours_TourId",
                table: "Players",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_TypeTours_TypeTourId",
                table: "Players",
                column: "TypeTourId",
                principalTable: "TypeTours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_TypeTours_TypeTourId",
                table: "Tours",
                column: "TypeTourId",
                principalTable: "TypeTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_FedexCups_FedexCupId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_GolfRankings_GolfRankingId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_PgaTours_PgaTourId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Tours_TourId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_FedexCups_PlayerQualifieds_PlayerQualifiedId",
                table: "FedexCups");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Courses_CourseId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Courses_CourseId1",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Tours_TourId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_TypeTours_TypeTourId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_TypeTours_TypeTourId",
                table: "Tours");

            migrationBuilder.DropTable(
                name: "PgaTours");

            migrationBuilder.DropTable(
                name: "PlayerQualifieds");

            migrationBuilder.DropIndex(
                name: "IX_TypeTours_IsDeleted",
                table: "TypeTours");

            migrationBuilder.DropIndex(
                name: "IX_Players_CourseId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_CourseId1",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_TourId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_FedexCups_PlayerQualifiedId",
                table: "FedexCups");

            migrationBuilder.DropIndex(
                name: "IX_Courses_FedexCupId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_GolfRankingId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_PgaTourId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TourId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "TypeTours");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "TypeTours");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TypeTours");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "TypeTours");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TourId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerQualifiedId",
                table: "FedexCups");

            migrationBuilder.DropColumn(
                name: "PrizeMoney",
                table: "FedexCups");

            migrationBuilder.DropColumn(
                name: "FedexCupId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "GolfRankingId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "PgaTourId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TourId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "PrizeMoney",
                table: "Tours",
                newName: "MoneyPrize");

            migrationBuilder.RenameColumn(
                name: "TypeTourId",
                table: "Players",
                newName: "GolfRankingId");

            migrationBuilder.RenameColumn(
                name: "ImagePlayer",
                table: "Players",
                newName: "Image");

            migrationBuilder.RenameIndex(
                name: "IX_Players_TypeTourId",
                table: "Players",
                newName: "IX_Players_GolfRankingId");

            migrationBuilder.RenameColumn(
                name: "PrizeMoney",
                table: "GolfRankings",
                newName: "ScoringRanking");

            migrationBuilder.RenameColumn(
                name: "TournamentsPlayed",
                table: "FedexCups",
                newName: "MoneyPrize");

            migrationBuilder.RenameColumn(
                name: "ImageCourse",
                table: "Courses",
                newName: "Image");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TypeTours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "TypeTourId",
                table: "Tours",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Points",
                table: "Tours",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Tours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Tours",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Courses",
                table: "Tours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Tours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GolfRankingId",
                table: "Tours",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Player",
                table: "Tours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Tours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TypeTour",
                table: "Tours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Players",
                type: "int",
                maxLength: 60,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Points",
                table: "GolfRankings",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "GolfTourUserId",
                table: "GolfRankings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MoneyPrize",
                table: "GolfRankings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Points",
                table: "FedexCups",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "FedexCups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "FedexCups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GolfRankingId",
                table: "FedexCups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GolfTourUserId",
                table: "FedexCups",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "FedexCups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Player",
                table: "FedexCups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Holes",
                table: "Courses",
                type: "int",
                maxLength: 18,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Par",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearBuilt",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CourseFedexCup",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    FedexCupsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFedexCup", x => new { x.CoursesId, x.FedexCupsId });
                    table.ForeignKey(
                        name: "FK_CourseFedexCup_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFedexCup_FedexCups_FedexCupsId",
                        column: x => x.FedexCupsId,
                        principalTable: "FedexCups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "FedexCupPlayer",
                columns: table => new
                {
                    FedexCupsId = table.Column<int>(type: "int", nullable: false),
                    PlayersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FedexCupPlayer", x => new { x.FedexCupsId, x.PlayersId });
                    table.ForeignKey(
                        name: "FK_FedexCupPlayer_FedexCups_FedexCupsId",
                        column: x => x.FedexCupsId,
                        principalTable: "FedexCups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FedexCupPlayer_Players_PlayersId",
                        column: x => x.PlayersId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FedexCupTour",
                columns: table => new
                {
                    FedexCupsId = table.Column<int>(type: "int", nullable: false),
                    ToursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FedexCupTour", x => new { x.FedexCupsId, x.ToursId });
                    table.ForeignKey(
                        name: "FK_FedexCupTour_FedexCups_FedexCupsId",
                        column: x => x.FedexCupsId,
                        principalTable: "FedexCups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FedexCupTour_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Newses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerTour",
                columns: table => new
                {
                    PlayersId = table.Column<int>(type: "int", nullable: false),
                    ToursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTour", x => new { x.PlayersId, x.ToursId });
                    table.ForeignKey(
                        name: "FK_PlayerTour_Players_PlayersId",
                        column: x => x.PlayersId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerTour_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_CourseId",
                table: "Tours",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_GolfRankingId",
                table: "Tours",
                column: "GolfRankingId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfRankings_GolfTourUserId",
                table: "GolfRankings",
                column: "GolfTourUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FedexCups_GolfRankingId",
                table: "FedexCups",
                column: "GolfRankingId");

            migrationBuilder.CreateIndex(
                name: "IX_FedexCups_GolfTourUserId",
                table: "FedexCups",
                column: "GolfTourUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFedexCup_FedexCupsId",
                table: "CourseFedexCup",
                column: "FedexCupsId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePlayer_PlayersId",
                table: "CoursePlayer",
                column: "PlayersId");

            migrationBuilder.CreateIndex(
                name: "IX_FedexCupPlayer_PlayersId",
                table: "FedexCupPlayer",
                column: "PlayersId");

            migrationBuilder.CreateIndex(
                name: "IX_FedexCupTour_ToursId",
                table: "FedexCupTour",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_Newses_IsDeleted",
                table: "Newses",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTour_ToursId",
                table: "PlayerTour",
                column: "ToursId");

            migrationBuilder.AddForeignKey(
                name: "FK_FedexCups_GolfRankings_GolfRankingId",
                table: "FedexCups",
                column: "GolfRankingId",
                principalTable: "GolfRankings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FedexCups_GolfTourUser_GolfTourUserId",
                table: "FedexCups",
                column: "GolfTourUserId",
                principalTable: "GolfTourUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GolfRankings_GolfTourUser_GolfTourUserId",
                table: "GolfRankings",
                column: "GolfTourUserId",
                principalTable: "GolfTourUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_GolfRankings_GolfRankingId",
                table: "Players",
                column: "GolfRankingId",
                principalTable: "GolfRankings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Courses_CourseId",
                table: "Tours",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_GolfRankings_GolfRankingId",
                table: "Tours",
                column: "GolfRankingId",
                principalTable: "GolfRankings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_TypeTours_TypeTourId",
                table: "Tours",
                column: "TypeTourId",
                principalTable: "TypeTours",
                principalColumn: "Id");
        }
    }
}
