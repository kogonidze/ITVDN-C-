namespace VehicleApp.Models;

internal class Ship : Vehicle
{
    public int PassengersCount { get; set; }

    public string PortOfResidence { get; set; }

    public Ship(double x, double y, decimal price, double speed, int year)
    : base(x, y, price, speed, year)
    {
    }

    public Ship(decimal price, int year)
        : base(price, year)
    {
    }
}
