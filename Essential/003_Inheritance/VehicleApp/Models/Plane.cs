namespace VehicleApp.Models;

internal class Plane : Vehicle
{
    public double HeightInSantimeters { get; set; }

    public int PassengersCount { get; set; }

    public Plane(double x, double y, decimal price, double speed, int year)
    : base(x, y, price, speed, year)
    {
    }

    public Plane(decimal price, int year)
        : base(price, year)
    {
    }
}
