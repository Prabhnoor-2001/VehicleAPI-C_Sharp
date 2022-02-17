namespace Vehicles;

public class BikeBuilder : IBikeBuilder
{
    private Bike _bike = new Bike();

    public BikeBuilder() : base()
    {
        
    }
    

    public IBikeBuilder SetManufacturer(string manufacturer)
    {
        _bike.Manufacturer = manufacturer;
        return this;
    }

    public IBikeBuilder SetModel(string model)
    {
        _bike.Model = model;
        return this;
    }

    public IBikeBuilder SetColour(string colour)
    {
        _bike.Colour = colour;
        return this;
    }

    public IBikeBuilder SetYear(int year)
    {
        _bike.Year = year;
        return this;
    }

    public IBikeBuilder setPrice(int price)
    {
        _bike.Price = price;
        return this;
    }

    public IBikeBuilder SetOwner(string name)
    {
        _bike.Owner = name;
        return this;
    }

    public IBikeBuilder SetTypeOfVehicle(VehicleType type)
    {
        _bike.Type = type;
        return this;
    }

    public Bike Build()
    {
        return _bike;
    }
}