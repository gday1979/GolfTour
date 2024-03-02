using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfTour.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDbTypeOfTour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeTourId",
                table: "Tours",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypeTours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTours", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TypeTourId",
                table: "Tours",
                column: "TypeTourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_TypeTours_TypeTourId",
                table: "Tours",
                column: "TypeTourId",
                principalTable: "TypeTours",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_TypeTours_TypeTourId",
                table: "Tours");

            migrationBuilder.DropTable(
                name: "TypeTours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_TypeTourId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "TypeTourId",
                table: "Tours");
        }
    }
}
