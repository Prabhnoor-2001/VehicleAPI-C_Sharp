using MongoDB.Driver;
using Vehicles.Services;
using WebApplication1.Models;
using AutoMapper;
var builder = WebApplication.CreateBuilder(args);



// configuring the database from appsettings
builder.Services.Configure<VehicleDatabaseSettings>(
    builder.Configuration.GetSection("CarsDatabase"));

builder.Services.AddScoped<ICarMovingService, CarMovingService>(); // this is available everywhere in this project now
builder.Services.AddScoped<IBikeMovingService, BikeMovingService>(); 
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



// Add services to the container.

builder.Services.AddControllers();
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

// var uri = app.Configuration["MongoURI"];


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();