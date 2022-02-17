

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Vehicles;

public class Vehicle : IVehicle
{
    [BsonId]
    public Guid _id { get; set; }
    
    [BsonElement("manufacturer")]
    public string Manufacturer { get; set; } // Manufacturer can be another class
    
    [BsonElement("model")]
    public string Model { get; set; } // Model can be another class
    
    [BsonElement("colour")]
    public string Colour { get; set; } // Colour can be another class
    
    [BsonElement("year")]
    public int Year { get; set; }
    
    [BsonElement("price")]
    public int Price { get; set; }
    
    [BsonElement("owner")]
    public string Owner { get; set; } // Owner can be another class

    [BsonElement("type")]
    public VehicleType Type { get; set; }
    

}