namespace Vehicles;

public interface IVehicle
{ 
    public string Manufacturer { get; set; } // Manufacturer can be another class
    
    public string Model { get; set; } // Model can be another class
    
    public string Colour { get; set; } // Colour can be another class
    
    public int Year { get; set; }
    
    public int Price { get; set; }
    
    public string Owner { get; set; } // Owner can be another class
    VehicleType Type { get; set; }
    
}