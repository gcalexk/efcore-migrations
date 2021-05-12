using Microsoft.EntityFrameworkCore.Migrations;

namespace efcore_bl.Migrations
{
    public partial class PositiveSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KnightTable",
                columns: new[] { "Id", "MaxSeats", "Shape" },
                values: new object[] { 1, 20, "Round" });

            migrationBuilder.InsertData(
                table: "TestKnights",
                columns: new[] { "Id", "Name", "Quest", "TableId" },
                values: new object[] { 1, "Lancelot", "To seek the holy grail", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestKnights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KnightTable",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
