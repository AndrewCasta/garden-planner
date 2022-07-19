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

app.Run();