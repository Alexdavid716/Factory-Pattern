using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of tires for the vehicle: ");
        int.TryParse(Console.ReadLine(), out int numberOfTires);

        try
        {
            // Get the vehicle from the factory based on the number of tires
            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfTires);
            Console.WriteLine("Vehicle created:");
            vehicle.Drive();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}