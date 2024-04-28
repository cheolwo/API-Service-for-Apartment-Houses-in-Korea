using Microsoft.OpenApi.Models;
using 국토교통부_공공데이터Common;
using 국토교통부_공공데이터Common.국토교통부_공동주택단지목록제공서비스;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

builder.Services.AddHttpClient();
builder.Services.AddScoped<IBuildingMaintenanceService, BuildingMaintenanceService>();
builder.Services.AddScoped<IAptListService, AptListService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
