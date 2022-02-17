namespace WebApplication1.Models;

public class VehicleDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string VehicleCollectionName { get; set; } = null!;
}