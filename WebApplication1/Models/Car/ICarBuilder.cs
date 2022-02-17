namespace Vehicles;

public interface ICarBuilder // should the setters in the vehicle class be private?
{
    public ICarBuilder SetManufacturer(string manufacturer);
    
    //Car(string manufacturer, string model, string colour, int year, int price, string owner, VehicleType type)
    public ICarBuilder SetModel(string model);

    public ICarBuilder SetColour(string colour);

    public ICarBuilder SetYear(int year);

    public ICarBuilder setPrice(int price);

    public ICarBuilder SetOwner(string name);

    public ICarBuilder SetTypeOfVehicle(VehicleType type);

    public Car Build();
}