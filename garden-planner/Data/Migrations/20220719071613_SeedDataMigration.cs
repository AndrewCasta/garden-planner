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
                values: new object[] { 1, false, "This is an aromatic herb which has many culinary uses, particularly popular in Mediterranean dishes.", "basil.svg", "Annual", "Basil", true, true, "Full", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 2, true, "Peas are best planted in Autumn & Winter, whilst most Beans are best planted in Spring & Summer. As part of the legume plant family, pea and bean plants.", "peas.svg", "Annual", "Peas", true, false, "Full", "Moderate", true });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 3, true, "A splendid maincrop carrot, producing long, pointed roots. Its fine colouring and excellent flavour make this one of the most appetising of carrots.", "carrot.svg", "Annual", "Carrot", true, true, "Full", "Moderate", true });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 4, false, "These tomatos are a favourite, with meaty flesh and very few seeds. Its excellent flavour makes it perfect for cooking or even eaten raw.", "tomato.svg", "Annual", "Tomato", true, true, "Full", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 5, false, "These peppers (chillies) are so useful in pickles, sauces and curries. Chilli vinegar can be made from the green fruits.", "chili.svg", "Annual", "Chili", true, true, "Full", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 6, true, "Very versatile herbs for rich meat dishes, especially lamb. Excellent in stuffings and an important flavouring in many Mediterranean dishes.", "rosemerry.svg", "Perennial", "Rosemerry", true, true, "Partial", "Moderate", true });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 7, true, "A mild flavour and tasty addition to salads. Prefers an open sunny position. Young tender tops can be used like chives.", "spring-onion.svg", "Perennial", "Spring Onion", true, true, "Partial", "Moderate", true });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 8, false, "Bring a taste of the Mediterranean to your life! The attractive green and red fruits will add colour to your garden, spice to your salads and variety to your cooking. ", "capsicum.svg", "Annual", "Capsicum", true, true, "Full", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 9, true, "In Greek cooking, mint is used in everything from cheese dishes to tomato-based sauces, meats, and rice dishes. ", "mint.svg", "Perennial", "Mint", true, true, "Partial", "Moderate", true });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 10, true, "The most widely grown lettuce. It has a tightly packed, crisp and very crunchy heart with sweet and delicious leaves. Easy to grow, hardy and reliable.", "lettuce.svg", "Annual", "Lettuce", true, true, "Full", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 11, true, "Our choice as the best all-round early onion, Hunter River Brown produces a large, globe-shaped onion with a light brown skin.", "onion.svg", "Annual", "Onion", false, false, "Full", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 12, true, "Popular, well-established variety producing high yields of large tasty sprouts. Medium height, well suited to the home garden.", "brussels-sprouts.svg", "Annual", "Brussels Sprouts", false, true, "Full", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 13, true, "Garlic is very easy to grow. Fresh Garlic from your garden is quite snappy, has a much stronger flavour.", "garlic.svg", "Annual", "Garlic", false, false, "Full", "Low", true });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 14, false, "An excellent, sweet tasting, burpless variety. The fruits can be eaten whole or sliced but are best when picked up to 10cm (4in) long. ", "cucumber.svg", "Annual", "Cucumber", true, true, "Full", "Low", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 15, false, "Sweet and tasty cherry sized fruits. A high yielding heirloom variety. Seed produced by Organic methods. Excellent source of vitamin C and antioxidants.", "cherry-tomato.svg", "Annual", "Cherry tomato", true, true, "Full", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 16, true, "One of our favourites and rapidly gaining in popularity, this delightful vegetable bridges the gap between Summer and Winter vegetables.", "broccoli.svg", "Annual", "Broccoli", false, true, "Full", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 17, true, "Provides a continuous harvest over a long period, has a mild delicate flavourideal for sandwiches or steaming.", "spinach.svg", "Perennial", "Spinach", true, true, "Full", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 18, true, "Slow bolting heirloom variety, Medium-sized round solid heads with few outer leaves. ", "cabbage.svg", "Annual", "Cabbage", false, true, "Partial", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 19, true, "An extremely useful cauliflower variety that produces large pure white heads with a first class flavour.", "cauliflower.svg", "Annual", "Cauliflower", false, true, "Partial", "Moderate", false });

            migrationBuilder.InsertData(
                table: "PlantVarieties",
                columns: new[] { "ID", "Autum", "Description", "Image", "Lifecycle", "Name", "Spring", "Summer", "Sun", "Water", "Winter" },
                values: new object[] { 20, false, "Jarrahdale is of excellent quality with a sweet flavour. Cuts well. Best results are obtained in full sun on rich, well drained soil.", "pumpkin.svg", "Annual", "Pumpkin", true, true, "Partial", "Moderate", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantVarieties");
        }
    }
}
