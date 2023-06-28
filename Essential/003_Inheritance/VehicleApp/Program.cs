using VehicleApp.Models;

var ship = new Ship(59.546, 34.6663, 5000000, 40, 2006)
{
    PassengersCount = 500,
    PortOfResidence = "Havana"
};

Console.WriteLine($"Location of the ship: ({ship.X};{ship.Y}), price: {ship.Price}, " +
    $"speed in km/h: {ship.SpeedInKmPerHour}, year of production: {ship.Year}");

Console.ReadKey();