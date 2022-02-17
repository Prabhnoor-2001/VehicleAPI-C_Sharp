using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApplication1.Models;

namespace Vehicles.Services;

public class BikeMovingService: IBikeMovingService
{
    
    
    private readonly IMongoCollection<Vehicle> _bikesService;
    
    public BikeMovingService(
        IOptions<VehicleDatabaseSettings> bikeDatabaseSettings) // NEED TO CONFIGURE THIS LATER
    {
        var mongoClient = new MongoClient(
           bikeDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
           bikeDatabaseSettings.Value.DatabaseName);

        _bikesService = mongoDatabase.GetCollection<Vehicle>(
           bikeDatabaseSettings.Value.VehicleCollectionName);
    }
    public void Move(IVehicle vehicle)
    {
        Console.WriteLine("im Riding");
    }

    public async Task AddAsync(Vehicle vehicle)
    {
        await _bikesService.InsertOneAsync(vehicle);
    }

    public async Task DeleteAsync(Guid vehicleId)
    {
        await _bikesService.DeleteOneAsync(x => x._id == vehicleId);
    }

    public async Task UpdateAsync( Guid vehicleId, Vehicle vehicle)
    {
        await _bikesService.ReplaceOneAsync(x => x._id == vehicleId, vehicle);
    }

   

    public async Task<List<Vehicle>> GetAsync(Guid vehicleId) // map from vehicle to car in the controller 
    {
         return await _bikesService.Find(car => car._id == vehicleId).ToListAsync();
    }
    
    public async Task<List<Vehicle>> GetAllAsync()
    {
        return await _bikesService.Find(bike => bike.Type == VehicleType.BIKE ).ToListAsync();
    }
    
}