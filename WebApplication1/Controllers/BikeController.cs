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
[Route("bike")]
public class BikeController : ControllerBase
{
    private readonly IBikeMovingService _BikeService;
    private readonly IMapper _mapper;
    // private readonly ILogger<BikeController> _logger;

    public BikeController(IBikeMovingService bikeService,IMapper mapper)
    {
        _BikeService = bikeService;
        _mapper = mapper;

    }

    [HttpGet]
    public async Task<List<VehicleContract>> Get() // use automapper here
    {
        
        var listOfvehicles = await _BikeService.GetAllAsync();
        var result = _mapper.Map<List<Vehicle>, List<VehicleContract>>(listOfvehicles);
        return result;

    }

    [HttpPost]
    public async Task post(
        [FromBody] Vehicle vehicle
    )
    {
        await _BikeService.AddAsync(vehicle);
    }
    
    [HttpPut("{vehicleId}")]
    public async Task Update(
        [FromBody] Vehicle vehicle,
        Guid vehicleId
    )
    {
        await _BikeService.UpdateAsync(vehicleId,vehicle);
    }

    [HttpDelete("{vehicleId}")]
    public async Task Delete(Guid vehicleId)
    {
        await _BikeService.DeleteAsync(vehicleId);
    }
}