namespace Vehicles;

public class Car : Vehicle
{
    public void LogFields()
    {
        Console.WriteLine($"{_id} \n {Manufacturer} \n {Model} \n {Colour} \n {Price} \n {Owner} \n {Year} \n");
    }
}