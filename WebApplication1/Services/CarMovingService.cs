using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApplication1.Models;

namespace Vehicles.Services;

public class CarMovingService : ICarMovingService
{
    
    
    private readonly IMongoCollection<Vehicle> _carsCollection;
    
    public CarMovingService(
        IOptions<CarsDatabaseSettings> carDatabaseSettings) // dont fully understand what is happening here
    {
        var mongoClient = new MongoClient(
            carDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            carDatabaseSettings.Value.DatabaseName);

        _carsCollection = mongoDatabase.GetCollection<Vehicle>(
            carDatabaseSettings.Value.CarsCollectionName);
    }


    public async Task<List<Vehicle>> GetAllAsync()
    {
        return await _carsCollection.Find(car => car.Type == VehicleType.CAR ).ToListAsync();
    }

    public void Move(IVehicle vehicle) // move the car thats passed in 
    {
        Console.WriteLine("im driving");
    }
    
    
    public async Task AddAsync(Vehicle vehicle)
    {
        await _carsCollection.InsertOneAsync(vehicle);
    }

    public async Task DeleteAsync(Guid vehicleId)
    {
        await _carsCollection.DeleteOneAsync(x => x._id == vehicleId);
    }

    public async Task UpdateAsync( Guid vehicleId, Vehicle vehicle)
    {
        vehicle._id = vehicleId;
        await _carsCollection.ReplaceOneAsync(x => x._id == vehicleId, vehicle);
    }

   

    public async Task<List<Vehicle>> GetAsync(Guid vehicleId) // map from vehicle to car in the controller 
    {
        return await _carsCollection.Find(car => car._id == vehicleId).ToListAsync();
    }

    
}