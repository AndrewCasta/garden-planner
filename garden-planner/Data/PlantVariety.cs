﻿using Microsoft.EntityFrameworkCore;

namespace garden_planner.Data
{
    public enum Lifecycle
    {
        Annual, Perennial
    }
    public enum Sun
    {
        Full, Partial, Shade
    }
    public enum Water
    {
        High, Moderate, Low
    }
    public class PlantVariety
    {

        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Lifecycle Lifecycle { get; set; }
        public Sun Sun { get; set; }
        public Water Water { get; set; }
        public bool Spring { get; set; }
        public bool Summer { get; set; }
        public bool Autum { get; set; }
        public bool Winter { get; set; }
        public string Image { get; set; } = string.Empty;

        public ICollection<CropPlantVariety> CropPlantVarieties { get; set; }

    }

    public class PlantVarietiesData
    {
        internal async static Task<List<PlantVariety>> GetPlantVarietiesAsync()
        {
            using (var db = new AppDBContext())
            {
                return await db.PlantVarieties.ToListAsync();
            }
        }
        internal async static Task<PlantVariety> GetPlantVarietyAsync(int id)
        {
            using (var db = new AppDBContext())
            {
                return await db.PlantVarieties.FirstOrDefaultAsync(plant => plant.ID == id);
            }
        }

    }
}
