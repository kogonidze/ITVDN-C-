namespace VehicleApp.Models;

internal class Car : Vehicle
{
    public Car(double x, double y, decimal price, double speed, int year)
        : base(x, y, price, speed, year)
    {
    }

    public Car(decimal price, int year)
        : base(price, year)
    { 
    }
}
