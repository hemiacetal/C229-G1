using Microsoft.EntityFrameworkCore.Migrations;

namespace C229_G1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    ClubFullName = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    HeadCoachName = table.Column<string>(nullable: true),
                    Ground = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.ClubFullName);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerName = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: true),
                    CountryOfBirth = table.Column<string>(nullable: true),
                    PlayingPosition = table.Column<string>(nullable: true),
                    ClubFullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerName);
                    table.ForeignKey(
                        name: "FK_Players_Clubs_ClubFullName",
                        column: x => x.ClubFullName,
                        principalTable: "Clubs",
                        principalColumn: "ClubFullName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_ClubFullName",
                table: "Players",
                column: "ClubFullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Clubs");
        }
    }
}
