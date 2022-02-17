using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Vehicles;
using Vehicles.Services;
using WebApplication1.Contracts;
using WebApplication1.Models.shipwreckExample;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
    private readonly ICarMovingService _CarService;
    private readonly IMapper _mapper;
    // private readonly ILogger<CarController> _logger;

    public CarController(ICarMovingService carService,IMapper mapper)
    {
        _CarService = carService;
        _mapper = mapper;

    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<List<VehicleContract>> Get() // use automapper here
    {
        
        var listOfvehicles = await _CarService.GetAllAsync();
        var result = _mapper.Map<List<Vehicle>, List<VehicleContract>>(listOfvehicles);
        return result;

    }

    [HttpPost]
    public async Task post(
        [FromBody] Vehicle vehicle
    )
    {
        await _CarService.AddAsync(vehicle);
    }
    
    [HttpPut("/{vehicleId}")]
    public async Task Update(
        [FromBody] Vehicle vehicle,
        Guid vehicleId
    )
    {
        await _CarService.UpdateAsync(vehicleId,vehicle);
    }

    [HttpDelete("/{vehicleId}")]
    public async Task Delete(Guid vehicleId)
    {
        await _CarService.DeleteAsync(vehicleId);
    }
}