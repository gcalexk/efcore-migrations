using Microsoft.EntityFrameworkCore.Migrations;

namespace efcore_bl.Migrations
{
    public partial class TableWithFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "TestKnights",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KnightTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shape = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MaxSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnightTable", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestKnights_TableId",
                table: "TestKnights",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestKnights_KnightTable_TableId",
                table: "TestKnights",
                column: "TableId",
                principalTable: "KnightTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestKnights_KnightTable_TableId",
                table: "TestKnights");

            migrationBuilder.DropTable(
                name: "KnightTable");

            migrationBuilder.DropIndex(
                name: "IX_TestKnights_TableId",
                table: "TestKnights");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "TestKnights");
        }
    }
}
