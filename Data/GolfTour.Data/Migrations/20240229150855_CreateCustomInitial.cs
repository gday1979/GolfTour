#nullable disable

namespace GolfTour.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    /// <inheritdoc />
    public partial class CreateCustomInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUserClaims",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Holes = table.Column<int>(type: "int", maxLength: 18, nullable: false),
                    Par = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Designer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearBuilt = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GolfTourUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfTourUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Newses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GolfRankings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Points = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MoneyPrize = table.Column<int>(type: "int", nullable: false),
                    TournamentsPlayed = table.Column<int>(type: "int", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    MoneyRanking = table.Column<int>(type: "int", nullable: false),
                    ScoringRanking = table.Column<int>(type: "int", nullable: false),
                    GolfTourUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfRankings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GolfRankings_GolfTourUser_GolfTourUserId",
                        column: x => x.GolfTourUserId,
                        principalTable: "GolfTourUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FedexCups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Points = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MoneyPrize = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GolfRankingId = table.Column<int>(type: "int", nullable: true),
                    GolfTourUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FedexCups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FedexCups_GolfRankings_GolfRankingId",
                        column: x => x.GolfRankingId,
                        principalTable: "GolfRankings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FedexCups_GolfTourUser_GolfTourUserId",
                        column: x => x.GolfTourUserId,
                        principalTable: "GolfTourUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    City = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 60, nullable: false),
                    YearsPro = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GolfRankingId = table.Column<int>(type: "int", nullable: true),
                    GolfTourUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_GolfRankings_GolfRankingId",
                        column: x => x.GolfRankingId,
                        principalTable: "GolfRankings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_GolfTourUser_GolfTourUserId",
                        column: x => x.GolfTourUserId,
                        principalTable: "GolfTourUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeTour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Courses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoneyPrize = table.Column<int>(type: "int", nullable: false),
                    Player = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Points = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    GolfRankingId = table.Column<int>(type: "int", nullable: true),
                    GolfTourUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tours_GolfRankings_GolfRankingId",
                        column: x => x.GolfRankingId,
                        principalTable: "GolfRankings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tours_GolfTourUser_GolfTourUserId",
                        column: x => x.GolfTourUserId,
                        principalTable: "GolfTourUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CourseFedexCup",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    FedexCupsId = table.Column<int>(type: "int", nullable: false),
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
                    PlayersId = table.Column<int>(type: "int", nullable: false),
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
                    PlayersId = table.Column<int>(type: "int", nullable: false),
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
                    ToursId = table.Column<int>(type: "int", nullable: false),
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
                name: "PlayerTour",
                columns: table => new
                {
                    PlayersId = table.Column<int>(type: "int", nullable: false),
                    ToursId = table.Column<int>(type: "int", nullable: false),
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
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_ApplicationUserId",
                table: "AspNetUserLogins",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_ApplicationUserId",
                table: "AspNetUserClaims",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFedexCup_FedexCupsId",
                table: "CourseFedexCup",
                column: "FedexCupsId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePlayer_PlayersId",
                table: "CoursePlayer",
                column: "PlayersId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_IsDeleted",
                table: "Courses",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_FedexCupPlayer_PlayersId",
                table: "FedexCupPlayer",
                column: "PlayersId");

            migrationBuilder.CreateIndex(
                name: "IX_FedexCups_GolfRankingId",
                table: "FedexCups",
                column: "GolfRankingId");

            migrationBuilder.CreateIndex(
                name: "IX_FedexCups_GolfTourUserId",
                table: "FedexCups",
                column: "GolfTourUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FedexCups_IsDeleted",
                table: "FedexCups",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_FedexCupTour_ToursId",
                table: "FedexCupTour",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfRankings_GolfTourUserId",
                table: "GolfRankings",
                column: "GolfTourUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfRankings_IsDeleted",
                table: "GolfRankings",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_GolfTourUser_IsDeleted",
                table: "GolfTourUser",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Newses_IsDeleted",
                table: "Newses",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Players_GolfRankingId",
                table: "Players",
                column: "GolfRankingId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_GolfTourUserId",
                table: "Players",
                column: "GolfTourUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_IsDeleted",
                table: "Players",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTour_ToursId",
                table: "PlayerTour",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_CourseId",
                table: "Tours",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_GolfRankingId",
                table: "Tours",
                column: "GolfRankingId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_GolfTourUserId",
                table: "Tours",
                column: "GolfTourUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_IsDeleted",
                table: "Tours",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_ApplicationUserId",
                table: "AspNetUserClaims",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_GolfTourUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "GolfTourUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_ApplicationUserId",
                table: "AspNetUserLogins",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_GolfTourUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "GolfTourUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_GolfTourUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "GolfTourUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_ApplicationUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_GolfTourUser_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_ApplicationUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_GolfTourUser_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_GolfTourUser_UserId",
                table: "AspNetUserRoles");

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

            migrationBuilder.DropTable(
                name: "FedexCups");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "GolfRankings");

            migrationBuilder.DropTable(
                name: "GolfTourUser");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_ApplicationUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_ApplicationUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUserClaims");
        }
    }
}
