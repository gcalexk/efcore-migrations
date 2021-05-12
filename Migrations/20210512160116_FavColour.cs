using Microsoft.EntityFrameworkCore.Migrations;

namespace efcore_bl.Migrations
{
    public partial class FavColour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavColour",
                table: "TestKnights",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavColour",
                table: "TestKnights");
        }
    }
}
