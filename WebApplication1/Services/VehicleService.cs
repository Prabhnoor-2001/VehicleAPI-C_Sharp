using System.Reflection;

namespace Vehicles.Services;

public class VehicleService : IVehicleService
{
    public void Add(IVehicle vehicle)
    {
        Console.WriteLine($"Add function was called by {vehicle.Type} ");
    }

    public void Delete(IVehicle vehicle)
    {
        // repo2.delete(v)
        Console.WriteLine($"Delete function was called by {vehicle.Type} ");
    }

    public void Update(ref IVehicle vehicle, IVehicle updatedVehicle)
    {
        Console.WriteLine($"Update function was called by {vehicle.Type} ");
        foreach (var prop in vehicle.GetType().GetProperties())
        {
            
            if (prop.GetValue(vehicle, null).ToString() != prop.GetValue(updatedVehicle, null).ToString())
            {
                Console.WriteLine($"{prop.Name} was changed");
            }
            // Console.WriteLine($"{prop.Name}: {prop.GetValue(vehicle, null)}");
        }
        vehicle = updatedVehicle;
        
    }

    public void Get(IVehicle vehicle)
    {
        Console.WriteLine($"Get function was called by {vehicle.Type} ");
        Console.WriteLine($"Here are the results: \n Manufacturer: {vehicle.Manufacturer} \n Model: {vehicle.Model} \n Year: {vehicle.Year} \n Price: {vehicle.Price} \n Owner: {vehicle.Owner} \n Colour: {vehicle.Colour} \n");
    }

    public void Move(IVehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public void UpdateCarprice(Car car)
    {
        throw new NotImplementedException();
    }

    public void UpdareBikePrice(Bike bike)
    {
        throw new NotImplementedException();
    }

    public void UpdatePrice(IVehicle vehicle)
    {
        vehicle.Price = 543589;
    }

    // public void Move(IMovingService service)
    // {
    //     service.Move();
    // }
    /*
     * or do it this way?
     *
     *public void Move(IVehicle vehicle)
    {
        switch(vehicle.Type){
            case vehicleType.CAR:
                NEW CarMovingService();
                break;
            case vehicleType.BIKE:
                NEW BikeMovingService();
                break; 
        }
        service.Move();
    }
     *
     * 
     */
}