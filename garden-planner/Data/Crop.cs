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

        internal async static Task<bool> CreateCropAsync(Crop crop)
        {
            using (var db = new AppDBContext())
            {
                await db.Crops.AddAsync(crop);
                return await db.SaveChangesAsync() >= 1;
            }
        }

        internal async static Task<bool> DeleteCropAsync(int id)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    Crop crop = await db.Crops.FindAsync(id);
                    db.Remove(crop);
                    return await db.SaveChangesAsync() >= 1;

                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return false;
                }
            }
        }
    }
}
