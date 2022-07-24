using System.Text.Json.Serialization;

using garden_planner.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:3000");
    });
});

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(opt =>
{
    opt.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CORSPolicy");

app.MapGet("/plant-varieties", async () =>
{
    List<PlantVariety> data = await PlantVarietiesData.GetPlantVarietiesAsync();
    return Results.Ok(data);
});

app.MapGet("/plant-varieties/{id}", async (int id) =>
{
    PlantVariety data = await PlantVarietiesData.GetPlantVarietyAsync(id);
    return Results.Ok(data);
});

app.MapGet("/crops", async () =>
{
    List<Crop> data = await CropData.GetCropsAsync();
    return Results.Ok(data);
});
app.MapGet("/crop/{id}", async (int id) =>
{
    Crop data = await CropData.GetCropAsync(id);
    return Results.Ok(data);
});
app.MapGet("/plant-varieties/crop/{id}", async (int id) =>
{
    List<int> data = await CropPlantVarietyData.GetCropPlantVarietiesAsync(id);
    return Results.Ok(data);
});

app.MapPost("/plant-varieties/crop/", async (CropPlantVariety cropPlantVariety) =>
{
    bool createSuccessful = await CropPlantVarietyData.CreateCropVarietySelectionAsync(cropPlantVariety);
    if (createSuccessful)
    {
        return Results.Ok("Success");
    }
    else
    {
        return Results.BadRequest();
    }
});

app.MapDelete("/plant-varieties/{variety-id}/crop/{crop-id}", async (int varietyID, int cropID) =>
{
    bool deleteSuccessful = await CropPlantVarietyData.DeleteCropVarietySelectionAsync(varietyID, cropID);
    System.Diagnostics.Debug.WriteLine($"Delete: {deleteSuccessful}");
    if (deleteSuccessful)
    {
        return Results.Ok("Success");
    }
    else
    {
        return Results.BadRequest();
    }
});

app.Run();