namespace Vehicles.Services;

public interface IVehicleService
{
    public Task AddAsync( Vehicle vehicle);
    public Task DeleteAsync(Guid vehicleId);
    public  Task UpdateAsync(Guid vehicleId, Vehicle vehicle);
    public Task<List<Vehicle>> GetAsync(Guid vehicleId);
    public Task<List<Vehicle>> GetAllAsync();
    public void Move(IVehicle vehicle);
    
}