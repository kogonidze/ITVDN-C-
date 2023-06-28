namespace VehicleApp.Models;

internal class Vehicle
{
    public double X { get; set; }

    public double Y { get; set; }

    public decimal Price { get; set; }

    public double SpeedInKmPerHour { get; set; }

    public int Year { get; set; }

    public Vehicle(double x, double y, decimal price, double speed, int year)
        : this(price, year)
    {
        X = x;
        Y = y;
        SpeedInKmPerHour = speed;
    }

    public Vehicle(decimal price, int year)
    {
        Price = price;
        Year = year;
    }
}
