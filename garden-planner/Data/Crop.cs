using Microsoft.EntityFrameworkCore;

namespace garden_planner.Data
{
    public class Crop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<CropPlantVariety> CropPlantVarieties { get; set; }
    }

    public class CropData
    {
        internal async static Task<List<Crop>> GetCropsAsync()
        {
            using (var db = new AppDBContext())
            {
                return await db.Crops.ToListAsync();
            }
        }
        internal async static Task<Crop> GetCropAsync(int id)
        {
            using (var db = new AppDBContext())
            {
                return await db.Crops.FirstOrDefaultAsync(crop => crop.ID == id);
            }
        }
    }
}
