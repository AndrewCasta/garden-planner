using Microsoft.EntityFrameworkCore;

namespace garden_planner.Data
{
    public class CropPlantVariety
    {
        public int ID { get; set; }
        public int PlantVarietyID { get; set; }
        public int CropID { get; set; }

        public PlantVariety PlantVariety { get; set; }
        public Crop Crop { get; set; }
    }

    public class CropPlantVarietyData
    {
        internal async static Task<List<CropPlantVariety>> GetCropPlantVarietiesMapAsync(int cropID)
        {
            using (var db = new AppDBContext())
            {
                return await db.CropPlantsVarieties.Where(crop => crop.ID == cropID).ToListAsync();
            }
        }
        internal async static Task<List<int>> GetCropPlantVarietiesAsync(int cropID)
        {
            using (var db = new AppDBContext())
            {
                return await db.CropPlantsVarieties.Where(c => c.CropID == cropID).Select(p => p.PlantVariety.ID).ToListAsync();
            }
        }

        internal async static Task<bool> CreateCropVarietySelectionAsync(CropPlantVariety cropPlantVariety)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    await db.CropPlantsVarieties.AddAsync(cropPlantVariety);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }

            }
        }

        internal async static Task<bool> DeleteCropVarietySelectionAsync(int varietyID, int cropID)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    List<CropPlantVariety> deletes = await db.CropPlantsVarieties.Where(c => c.CropID == cropID).Where(p => p.PlantVariety.ID == varietyID).ToListAsync();
                    foreach (CropPlantVariety plant in deletes)
                    {
                        db.CropPlantsVarieties.Remove(plant);
                    }
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
