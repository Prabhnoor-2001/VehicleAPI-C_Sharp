namespace Vehicles;

public interface IBikeBuilder // should the setters in the vehicle class be private?
{
    public IBikeBuilder SetManufacturer(string manufacturer);
    
    //Car(string manufacturer, string model, string colour, int year, int price, string owner, VehicleType type)
    public IBikeBuilder SetModel(string model);

    public IBikeBuilder SetColour(string colour);

    public IBikeBuilder SetYear(int year);

    public IBikeBuilder setPrice(int price);

    public IBikeBuilder SetOwner(string name);

    public IBikeBuilder SetTypeOfVehicle(VehicleType type);

    public Bike Build();
}