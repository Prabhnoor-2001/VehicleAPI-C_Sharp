using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApplication1.Models;

namespace Vehicles.Services;

public class BikeMovingService: IBikeMovingService
{
    
    
    private readonly IMongoCollection<Vehicle> _carsCollection;
    
    public BikeMovingService(
        IOptions<CarsDatabaseSettings> carDatabaseSettings) // NEED TO CONFIGURE THIS LATER
    {
        var mongoClient = new MongoClient(
            carDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            carDatabaseSettings.Value.DatabaseName);

        _carsCollection = mongoDatabase.GetCollection<Vehicle>(
            carDatabaseSettings.Value.CarsCollectionName);
    }
    public void Move(IVehicle vehicle)
    {
        Console.WriteLine("im Riding");
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
        await _carsCollection.ReplaceOneAsync(x => x._id == vehicle._id, vehicle);
    }

   

    public async Task<List<Vehicle>> GetAsync(Guid vehicleId) // map from vehicle to car in the controller 
    {
         return await _carsCollection.Find(car => car._id == vehicleId).ToListAsync();
    }
    
    public async Task<List<Vehicle>> GetAllAsync()
    {
        return await _carsCollection.Find(bike => bike.Type == VehicleType.BIKE ).ToListAsync();
    }


    public void UpdateBikePrice(Bike bike)
    {
        bike.Price = 453890;
    }
}