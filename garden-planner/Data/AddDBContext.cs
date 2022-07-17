using Microsoft.EntityFrameworkCore;

namespace garden_planner.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<PlantVariety> PlantVarieties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            PlantVariety[] plantVarietySeed = new PlantVariety[2];
            plantVarietySeed[0] = new PlantVariety
            {
                ID = 1,
                Name = "Basil",
                Description = "basil, (Ocimum basilicum), also called sweet basil, annual herb of the mint family ",
                Lifecycle = "Annual",
                Sun = "Full",
                Water = "High",
                Image = "basil.svg",
                Spring = true,
                Summer = true,
                Autum = false,
                Winter = false
            };
            plantVarietySeed[1] = new PlantVariety
            {
                ID = 2,
                Name = "Basil",
                Description = "The leaves are used fresh or dried to flavour meats, fish, salads, and sauces",
                Lifecycle = "Annual",
                Sun = "Full",
                Water = "High",
                Image = "basil.svg",
                Spring = true,
                Summer = true,
                Autum = false,
                Winter = false
            };

            modelBuilder.Entity<PlantVariety>().HasData(plantVarietySeed);
        }
    }
}
