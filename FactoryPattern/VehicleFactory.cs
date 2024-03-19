using System;


public static class VehicleFactory
{
    public static IVehicle GetVehicle(int numberOfTires)
    {
        switch (numberOfTires)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            default:
                throw new ArgumentException("Invalid number of tires. Cannot create a vehicle.");
        }
    }
}