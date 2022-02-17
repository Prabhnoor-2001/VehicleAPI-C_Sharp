namespace WebApplication1.Models;

public class CarsDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string CarsCollectionName { get; set; } = null!;
}