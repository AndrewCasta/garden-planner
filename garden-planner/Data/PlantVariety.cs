using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace garden_planner.Data
{
    enum Lifecycle
    {
        Annual, Perennial
    }
    enum Sun
    {
        Full, Partial, Shade
    }
    enum Water
    {
        High, Moderate, Low
    }
    internal sealed class PlantVariety
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
