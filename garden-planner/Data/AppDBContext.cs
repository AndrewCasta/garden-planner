using Microsoft.EntityFrameworkCore;

namespace garden_planner.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<PlantVariety> PlantVarieties { get; set; }
        public DbSet<Crop> Crops { get; set; }
        public DbSet<CropPlantVariety> CropPlantsVarieties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PlantVariety>().Property(e => e.Lifecycle).HasConversion<String>();
            modelBuilder.Entity<PlantVariety>().Property(e => e.Sun).HasConversion<String>();
            modelBuilder.Entity<PlantVariety>().Property(e => e.Water).HasConversion<String>();

            PlantVariety[] plantVarietySeed = new PlantVariety[20];
            Crop[] cropSeed = new Crop[1];
            CropPlantVariety[] cropPlantVarietySeed = new CropPlantVariety[2];

            cropSeed[0] = new Crop { ID = 1, Name = "First Crop" };
            cropPlantVarietySeed[0] = new CropPlantVariety { ID = 1, CropID = 1, PlantVarietyID = 1 };
            cropPlantVarietySeed[1] = new CropPlantVariety { ID = 2, CropID = 1, PlantVarietyID = 2 };


            plantVarietySeed[0] = new PlantVariety
            {
                ID = 1,
                Name = "Basil",
                Description = "This is an aromatic herb which has many culinary uses, particularly popular in Mediterranean dishes.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "basil.svg",
                Spring = true,
                Summer = true,
                Autum = false,
                Winter = false
            };
            plantVarietySeed[1] = new PlantVariety
            {
                ID = 2,
                Name = "Peas",
                Description = "Peas are best planted in Autumn & Winter, whilst most Beans are best planted in Spring & Summer. As part of the legume plant family, pea and bean plants.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "peas.svg",
                Spring = true,
                Summer = false,
                Autum = true,
                Winter = true
            };
            plantVarietySeed[2] = new PlantVariety
            {
                ID = 3,
                Name = "Carrot",
                Description = "A splendid maincrop carrot, producing long, pointed roots. Its fine colouring and excellent flavour make this one of the most appetising of carrots.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "carrot.svg",
                Spring = true,
                Summer = true,
                Autum = true,
                Winter = true
            };
            plantVarietySeed[3] = new PlantVariety
            {
                ID = 4,
                Name = "Tomato",
                Description = "These tomatos are a favourite, with meaty flesh and very few seeds. Its excellent flavour makes it perfect for cooking or even eaten raw.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "tomato.svg",
                Spring = true,
                Summer = true,
                Autum = false,
                Winter = false
            };
            plantVarietySeed[4] = new PlantVariety
            {
                ID = 5,
                Name = "Chili",
                Description = "These peppers (chillies) are so useful in pickles, sauces and curries. Chilli vinegar can be made from the green fruits.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "chili.svg",
                Spring = true,
                Summer = true,
                Autum = false,
                Winter = false
            };
            plantVarietySeed[5] = new PlantVariety
            {
                ID = 6,
                Name = "Rosemerry",
                Description = "Very versatile herbs for rich meat dishes, especially lamb. Excellent in stuffings and an important flavouring in many Mediterranean dishes.",
                Lifecycle = Lifecycle.Perennial,
                Sun = Sun.Partial,
                Water = Water.Moderate,
                Image = "rosemerry.svg",
                Spring = true,
                Summer = true,
                Autum = true,
                Winter = true
            };
            plantVarietySeed[6] = new PlantVariety
            {
                ID = 7,
                Name = "Spring Onion",
                Description = "A mild flavour and tasty addition to salads. Prefers an open sunny position. Young tender tops can be used like chives.",
                Lifecycle = Lifecycle.Perennial,
                Sun = Sun.Partial,
                Water = Water.Moderate,
                Image = "spring-onion.svg",
                Spring = true,
                Summer = true,
                Autum = true,
                Winter = true
            };
            plantVarietySeed[7] = new PlantVariety
            {
                ID = 8,
                Name = "Capsicum",
                Description = "Bring a taste of the Mediterranean to your life! The attractive green and red fruits will add colour to your garden, spice to your salads and variety to your cooking. ",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "capsicum.svg",
                Spring = true,
                Summer = true,
                Autum = false,
                Winter = false
            };
            plantVarietySeed[8] = new PlantVariety
            {
                ID = 9,
                Name = "Mint",
                Description = "In Greek cooking, mint is used in everything from cheese dishes to tomato-based sauces, meats, and rice dishes. ",
                Lifecycle = Lifecycle.Perennial,
                Sun = Sun.Partial,
                Water = Water.Moderate,
                Image = "mint.svg",
                Spring = true,
                Summer = true,
                Autum = true,
                Winter = true
            };
            plantVarietySeed[9] = new PlantVariety
            {
                ID = 10,
                Name = "Lettuce",
                Description = "The most widely grown lettuce. It has a tightly packed, crisp and very crunchy heart with sweet and delicious leaves. Easy to grow, hardy and reliable.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "lettuce.svg",
                Spring = true,
                Summer = true,
                Autum = true,
                Winter = false
            };
            plantVarietySeed[10] = new PlantVariety
            {
                ID = 11,
                Name = "Onion",
                Description = "Our choice as the best all-round early onion, Hunter River Brown produces a large, globe-shaped onion with a light brown skin.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "onion.svg",
                Spring = false,
                Summer = false,
                Autum = true,
                Winter = false
            };
            plantVarietySeed[11] = new PlantVariety
            {
                ID = 12,
                Name = "Brussels Sprouts",
                Description = "Popular, well-established variety producing high yields of large tasty sprouts. Medium height, well suited to the home garden.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "brussels-sprouts.svg",
                Spring = false,
                Summer = true,
                Autum = true,
                Winter = false
            };
            plantVarietySeed[12] = new PlantVariety
            {
                ID = 13,
                Name = "Garlic",
                Description = "Garlic is very easy to grow. Fresh Garlic from your garden is quite snappy, has a much stronger flavour.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Low,
                Image = "garlic.svg",
                Spring = false,
                Summer = false,
                Autum = true,
                Winter = true
            };
            plantVarietySeed[13] = new PlantVariety
            {
                ID = 14,
                Name = "Cucumber",
                Description = "An excellent, sweet tasting, burpless variety. The fruits can be eaten whole or sliced but are best when picked up to 10cm (4in) long. ",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Low,
                Image = "cucumber.svg",
                Spring = true,
                Summer = true,
                Autum = false,
                Winter = false
            };
            plantVarietySeed[14] = new PlantVariety
            {
                ID = 15,
                Name = "Cherry tomato",
                Description = "Sweet and tasty cherry sized fruits. A high yielding heirloom variety. Seed produced by Organic methods. Excellent source of vitamin C and antioxidants.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "cherry-tomato.svg",
                Spring = true,
                Summer = true,
                Autum = false,
                Winter = false
            };
            plantVarietySeed[15] = new PlantVariety
            {
                ID = 16,
                Name = "Broccoli",
                Description = "One of our favourites and rapidly gaining in popularity, this delightful vegetable bridges the gap between Summer and Winter vegetables.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "broccoli.svg",
                Spring = false,
                Summer = true,
                Autum = true,
                Winter = false
            };
            plantVarietySeed[16] = new PlantVariety
            {
                ID = 17,
                Name = "Spinach",
                Description = "Provides a continuous harvest over a long period, has a mild delicate flavourideal for sandwiches or steaming.",
                Lifecycle = Lifecycle.Perennial,
                Sun = Sun.Full,
                Water = Water.Moderate,
                Image = "spinach.svg",
                Spring = true,
                Summer = true,
                Autum = true,
                Winter = false
            };
            plantVarietySeed[17] = new PlantVariety
            {
                ID = 18,
                Name = "Cabbage",
                Description = "Slow bolting heirloom variety, Medium-sized round solid heads with few outer leaves. ",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Partial,
                Water = Water.Moderate,
                Image = "cabbage.svg",
                Spring = false,
                Summer = true,
                Autum = true,
                Winter = false
            };
            plantVarietySeed[18] = new PlantVariety
            {
                ID = 19,
                Name = "Cauliflower",
                Description = "An extremely useful cauliflower variety that produces large pure white heads with a first class flavour.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Partial,
                Water = Water.Moderate,
                Image = "cauliflower.svg",
                Spring = false,
                Summer = true,
                Autum = true,
                Winter = false
            };
            plantVarietySeed[19] = new PlantVariety
            {
                ID = 20,
                Name = "Pumpkin",
                Description = "Jarrahdale is of excellent quality with a sweet flavour. Cuts well. Best results are obtained in full sun on rich, well drained soil.",
                Lifecycle = Lifecycle.Annual,
                Sun = Sun.Partial,
                Water = Water.Moderate,
                Image = "pumpkin.svg",
                Spring = true,
                Summer = true,
                Autum = false,
                Winter = false
            };


            modelBuilder.Entity<PlantVariety>().HasData(plantVarietySeed);
            modelBuilder.Entity<Crop>().HasData(cropSeed);
            modelBuilder.Entity<CropPlantVariety>().HasData(cropPlantVarietySeed);

        }
    }
}
