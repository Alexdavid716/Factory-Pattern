using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of tires for the vehicle: ");
        int.TryParse(Console.ReadLine(), out int numberOfTires);

        try
        {
            
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