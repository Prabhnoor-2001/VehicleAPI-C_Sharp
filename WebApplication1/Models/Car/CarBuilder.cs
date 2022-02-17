namespace Vehicles;

public class CarBuilder : ICarBuilder// should i make a IBuilder? yes
{
    private Car _car = new Car();

    public CarBuilder() : base()
    {
        
    }
    

    public ICarBuilder SetManufacturer(string manufacturer)
    {
        _car.Manufacturer = manufacturer;
        return this;
    }

    public ICarBuilder SetModel(string model)
    {
        _car.Model = model;
        return this;
    }

    public ICarBuilder SetColour(string colour)
    {
        _car.Colour = colour;
        return this;
    }

    public ICarBuilder SetYear(int year)
    {
        _car.Year = year;
        return this;
    }

    public ICarBuilder   setPrice(int price)
    {
        _car.Price = price;
        return this;
    }

    public ICarBuilder   SetOwner(string name)
    {
        _car.Owner = name;
        return this;
    }

    public ICarBuilder   SetTypeOfVehicle(VehicleType type)
    {
        _car.Type = type;
        return this;
    }

    public Car Build()
    {
        return _car;
    }
}