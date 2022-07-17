using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace garden_planner.Data.Migrations
{
    public partial class SeedDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlantVarieties",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Lifecycle = table.Column<string>(type: "TEXT", nullable: false),
                    Sun = table.Column<string>(type: "TEXT", nullable: false),
                    Water = table.Column<string>(type: "TEXT", nullable: false),
                    Spring = table.Column<bool>(type: "INTEGER", nullable: false),
                    Summer = table.Column<bool>(type: "INTEGER", nullable: false),
                    Autum = table.Column<bool>(type: "INTEGER", nullable: false),
                    Winter = table.Column<bool>(type: "INTEGER", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantVarieties", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 1, false, "basil, (Ocimum basilicum), also called sweet basil, annual herb of the mint family ", "basil.svg", "Annual", "Basil", true, true, "Full", "High", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 2, false, "The leaves are used fresh or dried to flavour meats, fish, salads, and sauces", "basil.svg", "Annual", "Basil", true, true, "Full", "High", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantVarieties");
        }
    }
}
